using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace EFCoreMySqlApp.SoapServices
{
    [ServiceContract]
    public interface IWebService
    {
        string SayHello();
    }
}
