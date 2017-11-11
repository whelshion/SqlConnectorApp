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
                {"14", "Client.DataTran.ClientTranXmlImpl"},
                {"12", "Client.DataTran.ClientTranXmlImpl"},
                {"13", "Client.DataTran.ClientTranXmlImpl"},
                {"11", "Client.DataTran.ClientTranXmlImpl"},
                {"21", "Client.DataTran.ClientTranXmlImpl"},
                {"41", "Client.DataTran.ClientTranStrImpl"}
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
