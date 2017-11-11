using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CaspClient.Common.DataTran
{
    public class TranFactory
    {
        private static Dictionary<string, IClientTran> clientDataTranMap = new Dictionary<string, IClientTran>();

        public static IClientTran createClientTran(string dataFormatCode)
        {
            string dataTranClass = DataTranMapping.getDataTranClass(dataFormatCode);
            if (clientDataTranMap.ContainsKey(dataTranClass))
            {
                return clientDataTranMap[dataTranClass];
            }
            IClientTran clientTran = (IClientTran)typeof(TranFactory).GetTypeInfo().Assembly.CreateInstance(dataTranClass);
            clientDataTranMap.Add(dataTranClass, clientTran);
            return clientTran;
        }
    }
}
