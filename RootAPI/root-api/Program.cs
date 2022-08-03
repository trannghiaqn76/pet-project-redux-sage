using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace name_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        //public static void Main(string[] args)
        //{
        //    BuildWebHost(args).Run();
        //}
        //public static IWebHost BuildWebHost(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>()
        //        .UseUrls("http://0.0.0.0:5000")
        //        .UseKestrel(options =>
        //        {
        //            options.Limits.MaxRequestBodySize = null;
        //        }
        //        )
        //        .UseDefaultServiceProvider(options =>
        //            options.ValidateScopes = false)
        //        .Build();

    }
}
