using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Client.Config
{
    public class CaspServerConfig
    {
        private string id;

        private string ip;

        private int port;

        private int probePort;

        private int webServerPort;

        private bool isMaster;

        private string returnValue;

        private int timeOut;

        private string appContext;

        private string scheme;

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Ip
        {
            get
            {
                return this.ip;
            }
            set
            {
                this.ip = value;
            }
        }

        public int Port
        {
            get
            {
                return this.port;
            }
            set
            {
                this.port = value;
            }
        }

        public int ProbePort
        {
            get
            {
                return this.probePort;
            }
            set
            {
                this.probePort = value;
            }
        }

        public int WebServerPort
        {
            get
            {
                return this.webServerPort;
            }
            set
            {
                this.webServerPort = value;
            }
        }

        public bool IsMaster
        {
            get
            {
                return this.isMaster;
            }
            set
            {
                this.isMaster = value;
            }
        }

        public string ReturnValue
        {
            get
            {
                return this.returnValue;
            }
            set
            {
                this.returnValue = value;
            }
        }

        public int TimeOut
        {
            get
            {
                return this.timeOut;
            }
            set
            {
                this.timeOut = value;
            }
        }

        public string AppContext
        {
            get
            {
                return this.appContext;
            }
            set
            {
                this.appContext = value;
            }
        }

        public string Scheme
        {
            get
            {
                return this.scheme;
            }
            set
            {
                this.scheme = value;
            }
        }
    }
}
