using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.Code
{
    public class RequestTypeBodyMapping
    {
        private static Dictionary<string, string> requestTypeBodyMap;

        static RequestTypeBodyMapping()
        {
            requestTypeBodyMap = new Dictionary<string, string> {
                { "3", "CaspClient.Common.Data.UserInfo"},
                { "1", "CaspClient.Common.Data.TransferTicket"},
                { "4", "CaspClient.Common.Data.TransferTicket" },
                { "2", "CaspClient.Common.Data.TransferTicket" }
            };
        }

        public static string getBodyClass(string requestTypeCode)
        {
            if (requestTypeBodyMap.ContainsKey(requestTypeCode))
            {
                return requestTypeBodyMap[requestTypeCode];
            }
            return "";
        }
    }
}
