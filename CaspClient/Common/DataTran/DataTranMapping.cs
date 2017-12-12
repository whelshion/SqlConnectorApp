using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.DataTran
{
    public class DataTranMapping
    {
        private static Dictionary<string, string> dataTranMap;

        static DataTranMapping()
        {
            dataTranMap = new Dictionary<string, string>
            {
                {"14", "CaspClient.Client.DataTran.ClientTranXmlImpl"},
                {"12", "CaspClient.Client.DataTran.ClientTranXmlImpl"},
                {"13", "CaspClient.Client.DataTran.ClientTranXmlImpl"},
                {"11", "CaspClient.Client.DataTran.ClientTranXmlImpl"},
                {"21", "CaspClient.Client.DataTran.ClientTranXmlImpl"},
                {"41", "CaspClient.Client.DataTran.ClientTranStrImpl"}
            };
        }

        public static string getDataTranClass(string dataFormatCode)
        {
            if (dataTranMap.ContainsKey(dataFormatCode))
            {
                return dataTranMap[dataFormatCode].ToString();
            }
            return "";
        }
    }
}
