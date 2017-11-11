using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace CaspClient.Common.Socket
{
    public class UtfUtil
    {
        public static int writeUTF(string str, NetworkStream networkStream)
        {
            int length = str.Length;
            int num = 0;
            int num2 = 0;
            for (int i = 0; i < length; i++)
            {
                int num3 = (int)str[i];
                if (num3 >= 1 && num3 <= 127)
                {
                    num++;
                }
                else if (num3 > 2047)
                {
                    num += 3;
                }
                else
                {
                    num += 2;
                }
            }
            if (num > 65535)
            {
                throw new Exception("encoded string too long: " + num + " bytes");
            }
            byte[] array = new byte[num + 2];
            array[num2++] = (byte)(num >> 8 & 255);
            array[num2++] = (byte)(num & 255);
            for (int j = 0; j < length; j++)
            {
                int num3 = (int)str[j];
                if (num3 >= 1 && num3 <= 127)
                {
                    array[num2++] = (byte)num3;
                }
                else if (num3 > 2047)
                {
                    array[num2++] = (byte)(224 | (num3 >> 12 & 15));
                    array[num2++] = (byte)(128 | (num3 >> 6 & 63));
                    array[num2++] = (byte)(128 | (num3 & 63));
                }
                else
                {
                    array[num2++] = (byte)(192 | (num3 >> 6 & 31));
                    array[num2++] = (byte)(128 | (num3 & 63));
                }
            }
            networkStream.Write(array, 0, num + 2);
            return num + 2;
        }

        public static string readUTF(NetworkStream networkStream)
        {
            byte[] array = new byte[2];
            networkStream.Read(array, 0, 2);
            byte b = array[0];
            array[0] = array[1];
            array[1] = b;
            int num = (int)BitConverter.ToUInt16(array, 0);
            byte[] array2 = new byte[num];
            char[] array3 = new char[num];
            int i = 0;
            int length = 0;
            networkStream.Read(array2, 0, num);
            while (i < num)
            {
                int num2 = (int)(array2[i] & 255);
                switch (num2 >> 4)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        i++;
                        array3[length++] = (char)num2;
                        continue;
                    case 12:
                    case 13:
                        {
                            i += 2;
                            if (i > num)
                            {
                                throw new Exception("malformed input: partial character at end");
                            }
                            int num3 = (int)array2[i - 1];
                            if ((num3 & 192) != 128)
                            {
                                throw new Exception("malformed input around byte " + i);
                            }
                            array3[length++] = (char)((num2 & 31) << 6 | (num3 & 63));
                            continue;
                        }
                    case 14:
                        {
                            i += 3;
                            if (i > num)
                            {
                                throw new Exception("malformed input: partial character at end");
                            }
                            int num3 = (int)array2[i - 2];
                            int num4 = (int)array2[i - 1];
                            if ((num3 & 192) != 128 || (num4 & 192) != 128)
                            {
                                throw new Exception("malformed input around byte " + (i - 1));
                            }
                            array3[length++] = (char)((num2 & 15) << 12 | (num3 & 63) << 6 | (num4 & 63));
                            continue;
                        }
                }
                throw new Exception("malformed input around byte " + i);
            }
            return new string(array3, 0, length);
        }
    }
}
