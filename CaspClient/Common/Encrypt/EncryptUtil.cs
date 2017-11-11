using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace CaspClient.Common.Encrypt
{
    public class EncryptUtil
    {
        public static string generateOTPKey()
        {
            RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
            byte[] array = new byte[16];
            randomNumberGenerator.GetBytes(array);
            return Convert.ToBase64String(array);
        }
    }
}
