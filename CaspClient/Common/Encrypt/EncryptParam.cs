using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.Encrypt
{
    public class EncryptParam
    {
        private string type;

        private string key;

        private string value;

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public string Key
        {
            get
            {
                return this.key;
            }
            set
            {
                this.key = value;
            }
        }

        public string Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
    }
}
