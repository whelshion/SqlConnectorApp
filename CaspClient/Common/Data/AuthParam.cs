using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CaspClient.Common.Data
{
    public class AuthParam : Body
    {
        private string account;

        private string authType;

        private string certString;

        private string clientIp;

        private Dictionary<string, string> extend;

        private string passWord;

        private string pinCode;

        private string rootTicket;

        private string slaveAcc;

        private string targetAppCode;

        public string Account
        {
            get
            {
                return this.account;
            }
            set
            {
                this.account = value;
            }
        }

        public string AuthType
        {
            get
            {
                return this.authType;
            }
            set
            {
                this.authType = value;
            }
        }

        public string CertString
        {
            get
            {
                return this.certString;
            }
            set
            {
                this.certString = value;
            }
        }

        public string ClientIp
        {
            get
            {
                return this.clientIp;
            }
            set
            {
                this.clientIp = value;
            }
        }

        public Dictionary<string, string> Extend
        {
            get
            {
                return this.extend;
            }
            set
            {
                this.extend = value;
            }
        }

        public string PassWord
        {
            get
            {
                return this.passWord;
            }
            set
            {
                this.passWord = value;
            }
        }

        public string PinCode
        {
            get
            {
                return this.pinCode;
            }
            set
            {
                this.pinCode = value;
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

        public override string objToStr()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.AppIp + ",;");
            stringBuilder.Append(base.DescIp + ",;");
            stringBuilder.Append(base.RetCode + ",;");
            stringBuilder.Append(base.TempKey + ",;");
            stringBuilder.Append(this.account + ",;");
            stringBuilder.Append(this.authType + ",;");
            stringBuilder.Append(this.certString + ",;");
            stringBuilder.Append(this.clientIp + ",;");
            if (this.extend != null)
            {
                stringBuilder.Append("(");
                StringBuilder stringBuilder2 = new StringBuilder();
                foreach (string current in this.extend.Keys)
                {
                    stringBuilder2.Append(",;" + current + "=" + this.extend[current]);
                }
                stringBuilder.Append(stringBuilder2.ToString().Substring(",;".Length));
                stringBuilder.Append("),;");
            }
            stringBuilder.Append(this.passWord + ",;");
            stringBuilder.Append(this.pinCode + ",;");
            stringBuilder.Append(this.rootTicket + ",;");
            stringBuilder.Append(this.slaveAcc + ",;");
            stringBuilder.Append(this.targetAppCode + ",;");
            stringBuilder.Append(base.ServerId);
            return stringBuilder.ToString();
        }

        public override void strToObj(string data)
        {
            Regex regex = new Regex("(^[(|)]*),;");
            if (regex.IsMatch(data))
            {
                this.extend = new Dictionary<string, string>();
                string text = regex.Match(data).Value;
                text = text.Substring("(".Length);
                text = text.Substring(0, text.Length - ")".Length - ",;".Length);
                string[] array = text.Split(new string[]
                {
                    ",;"
                }, StringSplitOptions.None);
                for (int i = 0; i < array.Length; i++)
                {
                    string[] array2 = array[i].Split(new string[]
                    {
                        "="
                    }, StringSplitOptions.None);
                    this.extend.Add(array2[0], array2[1]);
                }
                data = regex.Replace(data, "");
            }
            string[] array3 = data.Split(new string[]
            {
                ",;"
            }, StringSplitOptions.None);
            base.AppIp = array3[0];
            base.DescIp = array3[1];
            base.RetCode = array3[2];
            base.TempKey = array3[3];
            this.account = array3[4];
            this.authType = array3[5];
            this.certString = array3[6];
            this.clientIp = array3[7];
            this.passWord = array3[8];
            this.pinCode = array3[9];
            this.rootTicket = array3[10];
            this.slaveAcc = array3[11];
            this.targetAppCode = array3[12];
            base.ServerId = array3[13];
        }
    }
}
