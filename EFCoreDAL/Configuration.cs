using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace EFCoreDAL
{
    public class Configuration
    {
        public static IConfigurationRoot configuration;

        public static string GetConnectionString(string name)
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json");

            configuration = builder.Build();
            return configuration["ConnectionStrings:" + name];

        }
    }
}
