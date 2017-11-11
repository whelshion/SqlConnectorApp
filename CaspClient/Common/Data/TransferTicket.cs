using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.Data
{
    public class TransferTicket : Body
    {
        private string random;

        private string rootTicket;

        private string slaveAcc;

        private string ssoTicket;

        private string targetAppCode;

        private string timeStamp;

        public string Random
        {
            get
            {
                return this.random;
            }
            set
            {
                this.random = value;
            }
        }

        public string RootTicket
        {
            get
            {
                return this.rootTicket;
            }
            set
            {
                this.rootTicket = value;
            }
        }

        public string SlaveAcc
        {
            get
            {
                return this.slaveAcc;
            }
            set
            {
                this.slaveAcc = value;
            }
        }

        public string SsoTicket
        {
            get
            {
                return this.ssoTicket;
            }
            set
            {
                this.ssoTicket = value;
            }
        }

        public string TargetAppCode
        {
            get
            {
                return this.targetAppCode;
            }
            set
            {
                this.targetAppCode = value;
            }
        }

        public string TimeStamp
        {
            get
            {
                return this.timeStamp;
            }
            set
            {
                this.timeStamp = value;
            }
        }

        public override string objToStr()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.AppIp + ",;");
            stringBuilder.Append(base.DescIp + ",;");
            stringBuilder.Append(base.RetCode + ",;");
            stringBuilder.Append(base.TempKey + ",;");
            stringBuilder.Append(this.random + ",;");
            stringBuilder.Append(this.rootTicket + ",;");
            stringBuilder.Append(this.slaveAcc + ",;");
            stringBuilder.Append(this.ssoTicket + ",;");
            stringBuilder.Append(this.targetAppCode + ",;");
            stringBuilder.Append(this.timeStamp + ",;");
            stringBuilder.Append(base.ServerId);
            return stringBuilder.ToString();
        }

        public override void strToObj(string data)
        {
            string[] array = data.Split(new string[]
            {
                ",;"
            }, StringSplitOptions.None);
            base.AppIp = array[0];
            base.DescIp = array[1];
            base.RetCode = array[2];
            base.TempKey = array[3];
            this.random = array[4];
            this.rootTicket = array[5];
            this.slaveAcc = array[6];
            this.ssoTicket = array[7];
            this.targetAppCode = array[8];
            this.timeStamp = array[9];
            base.ServerId = array[10];
        }
    }
}
