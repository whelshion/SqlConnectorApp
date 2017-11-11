using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.Encrypt
{
    public interface IEncrypter
    {
        string encode(EncryptParam param);

        string decode(EncryptParam param);
    }
}
