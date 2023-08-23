using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppConfigExample
{
    internal class Program
    {
        //In your console application code,
        //you can access the configuration settings using the ConfigurationManager class from the System.Configuration namespace.

        static void Main(string[] args)
        {

            var appSettings = ConfigurationManager.AppSettings;

            foreach (string key in appSettings.AllKeys)
            {
                string value = appSettings[key];
                string[] parts = value.Split(' ');
               
                Console.WriteLine("===============");

                string server = "";
                string database = "";
               
                
               
                foreach (string part in parts)
                {
                   
                    if (part.StartsWith("server="))
                    {
                        server = part.Substring(7);
                       
                    }
                    else if (part.StartsWith("database="))
                    {
                        database = part.Substring(9);
                       
                    }
                }
                Console.WriteLine($"Connection Key: {key}");
                Console.WriteLine($"Server: {server}");
                Console.WriteLine($"Database: {database}");



                Console.WriteLine();
            }
           

           



        }
    }
}
