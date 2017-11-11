using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.Data
{
    public class CaspResponse
    {
        private Header header;

        private Body body;

        public Header Header
        {
            get
            {
                return this.header;
            }
            set
            {
                this.header = value;
            }
        }

        public Body Body
        {
            get
            {
                return this.body;
            }
            set
            {
                this.body = value;
            }
        }
    }
}
