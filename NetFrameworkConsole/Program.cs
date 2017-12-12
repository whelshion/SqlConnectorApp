using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSCAccountWS();
        }

        private static void TestSCAccountWS()
        {
            var wsClient = new SCAccountWS.AccountServiceSoapClient();
            var result = wsClient.queryUsersAsync().Result;
            Console.WriteLine(result.Body.queryUsersResult);
            Console.ReadKey();
        }
    }
}
