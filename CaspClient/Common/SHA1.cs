using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CaspClient.Common
{
    //public class SHA1
    //{
    //    public static string encode(string clearText)
    //    {
    //        byte[] bytes = Encoding.Default.GetBytes(clearText);
    //        HashAlgorithm hashAlgorithm = HashAlgorithm.Create("SHA1");
    //        byte[] inArray = hashAlgorithm.ComputeHash(bytes);
    //        return Convert.ToBase64String(inArray);
    //    }
    //}
    public class SHA1
    {
        public static string encode(string clearText)
        {
            byte[] bytes = Encoding.GetEncoding(0).GetBytes(clearText);
            HashAlgorithm hashAlgorithm = System.Security.Cryptography.SHA1.Create(); 
            byte[] inArray = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }
    }
}
