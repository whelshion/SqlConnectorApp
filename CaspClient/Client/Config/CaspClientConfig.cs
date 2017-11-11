using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Client.Config
{
    public class CaspClientConfig
    {
        private bool enableCaspClient;

        private string appCode;

        private string appKey;

        private bool queryStateEnable;

        private bool hasbak;

        private int switchcycletime;

        private string loginUrl;

        private string agentSsoUrl;

        private string dataFormatMode;

        private string encodeType;

        public bool EnableCaspClient
        {
            get
            {
                return this.enableCaspClient;
            }
            set
            {
                this.enableCaspClient = value;
            }
        }

        public string AppCode
        {
            get
            {
                return this.appCode;
            }
            set
            {
                this.appCode = value;
            }
        }

        public string AppKey
        {
            get
            {
                return this.appKey;
            }
            set
            {
                this.appKey = value;
            }
        }

        public bool QueryStateEnable
        {
            get
            {
                return this.queryStateEnable;
            }
            set
            {
                this.queryStateEnable = value;
            }
        }

        public bool Hasbak
        {
            get
            {
                return this.hasbak;
            }
            set
            {
                this.hasbak = value;
            }
        }

        public int Switchcycletime
        {
            get
            {
                return this.switchcycletime;
            }
            set
            {
                this.switchcycletime = value;
            }
        }

        public string LoginUrl
        {
            get
            {
                return this.loginUrl;
            }
            set
            {
                this.loginUrl = value;
            }
        }

        public string AgentSsoUrl
        {
            get
            {
                return this.agentSsoUrl;
            }
            set
            {
                this.agentSsoUrl = value;
            }
        }

        public string DataFormatMode
        {
            get
            {
                return this.dataFormatMode;
            }
            set
            {
                this.dataFormatMode = value;
            }
        }

        public string EncodeType
        {
            get
            {
                return this.encodeType;
            }
            set
            {
                this.encodeType = value;
            }
        }
    }
}
