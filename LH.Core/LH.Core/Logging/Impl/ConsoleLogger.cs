using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LH.Core.Logging.Impl
{
    public class ConsoleLogger : ILog
    {
        private const string MESSAGE_TEMP = "[{0} - {1}] {2}: {3}";
        private const string MESSAGE_ERR_TEMP = "[{0} - {1}] {2}: {3}\n{4}";

        public void D(string tag, string msg)
        {
            Console.WriteLine(MESSAGE_TEMP, DateTimeOffset.Now, "Debug", tag, msg);
        }

        public void D(string tag, string msg, Exception e)
        {
            Console.WriteLine(MESSAGE_TEMP, DateTimeOffset.Now, "Debug", tag, msg, e);
        }

        public void E(string tag, string msg)
        {
            Console.WriteLine(MESSAGE_TEMP, DateTimeOffset.Now, "Error", tag, msg);
        }

        public void E(string tag, string msg, Exception e)
        {
            Console.WriteLine(MESSAGE_TEMP, DateTimeOffset.Now, "Error", tag, msg, e);
        }

        public void I(string tag, string msg)
        {
            Console.WriteLine(MESSAGE_TEMP, DateTimeOffset.Now, "Information", tag, msg);
        }

        public void I(string tag, string msg, Exception e)
        {
            Console.WriteLine(MESSAGE_TEMP, DateTimeOffset.Now, "Information", tag, msg, e);
        }

        public void W(string tag, string msg)
        {
            Console.WriteLine(MESSAGE_TEMP, DateTimeOffset.Now, "Warning", tag, msg);
        }

        public void W(string tag, string msg, Exception e)
        {
            Console.WriteLine(MESSAGE_TEMP, DateTimeOffset.Now, "Warning", tag, msg, e);
        }
    }
}
