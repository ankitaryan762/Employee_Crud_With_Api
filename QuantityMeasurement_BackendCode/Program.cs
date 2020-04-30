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
using StackExchange.Redis;

namespace QuantityMeasurement_BackendCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
            //IDatabase db = redis.GetDatabase();
            //var val = db.StringGet("k1");
            //Console.WriteLine(val);

            Receiver receiver = new Receiver();
            receiver.ReceiveMessage();

            BuildWebHost(args).Run();
      
        }
        public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();
    }
}
