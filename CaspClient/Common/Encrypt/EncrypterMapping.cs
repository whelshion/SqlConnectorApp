using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.Encrypt
{
    public class EncrypterMapping
    {
        private static Dictionary<string, string> encrypterMap;

        static EncrypterMapping()
        {
            encrypterMap = new Dictionary<string, string> {
                {"1", "CaspClient.Common.Encrypt.DESEncryptImpl"}
            };
        }

        public static string getEncrypterClass(string encodeType)
        {
            if (encrypterMap.ContainsKey(encodeType))
            {
                return encrypterMap[encodeType].ToString();
            }
            return "";
        }
    }
}
