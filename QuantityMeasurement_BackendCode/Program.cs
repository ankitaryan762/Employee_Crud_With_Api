using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using QuantityMeasurement_BackendCode.services;

namespace QuantityMeasurement_BackendCode
{
    public class Program
    {
        Sender sender = null;
        Receiver receiver = null;
        public static void Main(string[] args)
        {
            Sender sender = null;
            Receiver receiver = null;
            BuildWebHost(args).Run();
            sender.main(args);
            receiver.main(args);
        }
        public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();
    }
}
