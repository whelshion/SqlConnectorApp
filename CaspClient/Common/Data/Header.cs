using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.Data
{
    public class Header
    {
        private string requestTypeCode;

        private string date;

        private string sign;

        private string dataFormatMode;

        private string appCode;

        public string RequestTypeCode
        {
            get
            {
                return this.requestTypeCode;
            }
            set
            {
                this.requestTypeCode = value;
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string Sign
        {
            get
            {
                return this.sign;
            }
            set
            {
                this.sign = value;
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

        public string objToStr()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.requestTypeCode + ",;");
            stringBuilder.Append(this.date + ",;");
            stringBuilder.Append(this.sign + ",;");
            stringBuilder.Append(this.dataFormatMode + ",;");
            stringBuilder.Append(this.appCode);
            return stringBuilder.ToString();
        }

        public void strToObj(string data)
        {
            string[] array = data.Split(new string[]
            {
                ",;"
            }, StringSplitOptions.None);
            this.requestTypeCode = array[0];
            this.date = array[1];
            this.sign = array[2];
            this.dataFormatMode = array[3];
            this.appCode = array[4];
        }
    }
}
