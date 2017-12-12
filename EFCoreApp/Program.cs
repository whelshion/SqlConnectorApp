using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using CaspClient.Client;

namespace EFCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoginUtil.getInstance().init(Path.Combine(Environment.CurrentDirectory,"casp_client_config.xml"));
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
