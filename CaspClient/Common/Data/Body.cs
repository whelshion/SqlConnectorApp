
using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.Data
{
    public abstract class Body
    {
        private string appIp;

        private string descIp;

        private string retCode;

        private string tempKey;

        private string serverId;

        public string AppIp
        {
            get
            {
                return this.appIp;
            }
            set
            {
                this.appIp = value;
            }
        }

        public string DescIp
        {
            get
            {
                return this.descIp;
            }
            set
            {
                this.descIp = value;
            }
        }

        public string RetCode
        {
            get
            {
                return this.retCode;
            }
            set
            {
                this.retCode = value;
            }
        }

        public string TempKey
        {
            get
            {
                return this.tempKey;
            }
            set
            {
                this.tempKey = value;
            }
        }

        public string ServerId
        {
            get
            {
                return this.serverId;
            }
            set
            {
                this.serverId = value;
            }
        }

        public abstract string objToStr();

        public abstract void strToObj(string data);
    }
}
