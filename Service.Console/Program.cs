using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Console
{
    using Patterns.ServiceLocator;
    using Logging;
    using System.Configuration;

    class Program
    {
        static void Main(string[] args)
        {
            ServiceLocator.RegisterService("Logging");
            var log =(ILogging) ServiceLocator.GetService<ILogging>("log");

            log.Log("hello world using loosely coupled service locator");

            System.Console.ReadLine();
        }
    }
}
