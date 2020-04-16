using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using static System.Collections.Specialized.BitVector32;

namespace HomerEndpoints
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReadEnvironmentVariable("Environment.ini");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)

                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                    .UseStartup<Startup>();
                });


        /// <summary>
        /// This funciton is used to read Env Variables
        /// </summary>
        public static void ReadEnvironmentVariable(string filename)
        {
            string[] lines = File.ReadAllLines(filename);

            for (var i = 0; i <= lines.Length - 1; i++)
            {
                var allVariables = lines[i].Split(new char[] { '=' }, 2);
                var variableName = allVariables[0];
                var variableValue = string.Empty;
                for (int j = 1; j < allVariables.Length; j++)
                {
                    variableValue = variableValue + allVariables[j];
                }
                Environment.SetEnvironmentVariable(variableName, variableValue);
            }
        }


    }
}
