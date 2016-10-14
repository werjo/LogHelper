using LH.Core.Logging.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LH.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new ConsoleLogger();
            consoleLogger.D(typeof(Program).Name, "Debug Message with Exception", new Exception("exe"));
            consoleLogger.W(typeof(Program).Name, "Warning Message with Exception", new Exception("exe"));
            var traceLogger = new TraceLogger();
            traceLogger.I(typeof(Program).Name, "Information Message with Exception", new Exception("exe"));
            traceLogger.E(typeof(Program).Name, "Error Message with Exception", new Exception("exe"));
            Console.ReadLine();
        }
    }
}
