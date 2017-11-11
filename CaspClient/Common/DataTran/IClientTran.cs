using CaspClient.Common.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.DataTran
{
    public interface IClientTran
    {
        string tranResquestToStr(CaspRequest request, string key);

        CaspResponse tranStrToResponse(string data, string key);

        Body tranStrToBody(string data, string key, string className);
    }
}
