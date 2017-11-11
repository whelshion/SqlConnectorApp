using CaspClient.Client.Config;
using CaspClient.Common.Data;
using CaspClient.Common.DataTran;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Client.Socket
{
    public class CaspSocket
    {
        public static async System.Threading.Tasks.Task<CaspResponse> send(CaspRequest request)
        {
            IClientTran clientTran = TranFactory.createClientTran(CaspConfigUtil.CaspClientConfig.DataFormatMode);
            string requestStr = clientTran.tranResquestToStr(request, CaspConfigUtil.CaspClientConfig.AppKey);
            string text = await StringSocket.send(requestStr);
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }
            return clientTran.tranStrToResponse(text, request.Body.TempKey);
        }
    }
}
