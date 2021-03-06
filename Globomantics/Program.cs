﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;


namespace Globomantics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://localhost:44311")
                .UseStartup<Startup>()
                .Build();
    }
}


