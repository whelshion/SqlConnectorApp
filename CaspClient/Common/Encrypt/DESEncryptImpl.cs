using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CaspClient.Common.Encrypt
{
    public class DESEncryptImpl : IEncrypter
    {
        private UTF8Encoding utf8 = new UTF8Encoding();

        public string encode(EncryptParam param)
        {
            byte[] bytes = this.utf8.GetBytes(param.Value);
            ICryptoTransform cryptoTransform = this.createEncryptor(param.Key);
            byte[] inArray = this.transform(bytes, cryptoTransform);
            return Convert.ToBase64String(inArray);
        }

        public string decode(EncryptParam param)
        {
            byte[] input = Convert.FromBase64String(param.Value);
            ICryptoTransform cryptoTransform = this.createDecryptor(param.Key);
            byte[] bytes = this.transform(input, cryptoTransform);
            return this.utf8.GetString(bytes);
        }

        private byte[] transform(byte[] input, ICryptoTransform cryptoTransform)
        {
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
            cryptoStream.Write(input, 0, input.Length);
            cryptoStream.FlushFinalBlock();
            memoryStream.Position = 0L;
            byte[] result = memoryStream.ToArray();
            memoryStream.Dispose();
            cryptoStream.Dispose();
            return result;
        }

        private ICryptoTransform createEncryptor(string key)
        {
            TripleDES tripleDES = this.createCryptoProvider(key);
            return tripleDES.CreateEncryptor();
        }

        private ICryptoTransform createDecryptor(string key)
        {
            TripleDES tripleDES = this.createCryptoProvider(key);
            return tripleDES.CreateDecryptor();
        }

        private TripleDES createCryptoProvider(string key)
        {
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Key = this.generateKey(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            return tripleDES;
        }

        private byte[] generateKey(string key)
        {
            byte[] array = new byte[24];
            byte[] bytes = this.utf8.GetBytes(key);
            int i = 0;
            int num = 0;
            while (i < array.Length)
            {
                array[i] = bytes[num];
                if (num == bytes.Length - 1)
                {
                    num = -1;
                }
                i++;
                num++;
            }
            return array;
        }
    }
}
