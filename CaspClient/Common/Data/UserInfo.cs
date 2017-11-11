using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.Data
{
    public class UserInfo : Body
    {
        private string name;

        private string accountID;

        private string empNo;

        private string phone;

        private string mobile;

        private string email;

        private string idCardNum;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string AccountID
        {
            get
            {
                return this.accountID;
            }
            set
            {
                this.accountID = value;
            }
        }

        public string EmpNo
        {
            get
            {
                return this.empNo;
            }
            set
            {
                this.empNo = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            set
            {
                this.mobile = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string IdCardNum
        {
            get
            {
                return this.idCardNum;
            }
            set
            {
                this.idCardNum = value;
            }
        }

        public override string objToStr()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.AppIp + ",;");
            stringBuilder.Append(base.DescIp + ",;");
            stringBuilder.Append(base.RetCode + ",;");
            stringBuilder.Append(base.TempKey + ",;");
            stringBuilder.Append(this.name + ",;");
            stringBuilder.Append(this.accountID + ",;");
            stringBuilder.Append(this.empNo + ",;");
            stringBuilder.Append(this.phone + ",;");
            stringBuilder.Append(this.mobile + ",;");
            stringBuilder.Append(this.email + ",;");
            stringBuilder.Append(this.idCardNum + ",;");
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
            this.name = array[4];
            this.accountID = array[5];
            this.empNo = array[6];
            this.phone = array[7];
            this.mobile = array[8];
            this.email = array[9];
            this.idCardNum = array[10];
            base.ServerId = array[11];
        }
    }
}
