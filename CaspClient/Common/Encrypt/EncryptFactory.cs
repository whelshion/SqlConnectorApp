using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CaspClient.Common.Encrypt
{
    public class EncryptFactory
    {
        private static Dictionary<string,IEncrypter> encrypterMap = new Dictionary<string, IEncrypter>();

        public static IEncrypter createEncrypter(string encodeType)
        {
            string encrypterClass = EncrypterMapping.getEncrypterClass(encodeType);
            if (encrypterMap.ContainsKey(encrypterClass))
            {
                return encrypterMap[encrypterClass];
            }
            IEncrypter encrypter = (IEncrypter)typeof(EncryptFactory).GetTypeInfo().Assembly.CreateInstance(encrypterClass);
            encrypterMap.Add(encrypterClass, encrypter);
            return encrypter;
        }
    }
}
