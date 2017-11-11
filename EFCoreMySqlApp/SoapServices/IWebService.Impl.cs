using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreMySqlApp.SoapServices
{
    public class WebService : IWebService
    {
        public string SayHello()
        {
            return "Hello Web Service!";
        }
    }
}
