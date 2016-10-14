using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LH.Core.Logging.Impl
{
    public class TraceLogger : ILog
    {
        public void D(string tag, string msg)
        {
            I(tag, msg);
        }

        public void D(string tag, string msg, Exception e)
        {
            I(tag, msg, e);
        }

        public void E(string tag, string msg)
        {
            Trace.TraceError($"[{tag}] {msg}");
        }

        public void E(string tag, string msg, Exception e)
        {
            Trace.TraceError($"[{tag}] {msg}{Environment.NewLine}{e}");
        }

        public void I(string tag, string msg)
        {
            Trace.TraceInformation($"[{tag}] {msg}");
        }

        public void I(string tag, string msg, Exception e)
        {
            Trace.TraceInformation($"[{tag}] {msg}{Environment.NewLine}{e}");
        }

        public void W(string tag, string msg)
        {
            Trace.TraceWarning($"[{tag}] {msg}");
        }

        public void W(string tag, string msg, Exception e)
        {
            Trace.TraceWarning($"[{tag}] {msg}{Environment.NewLine}{e}");
        }
    }
}
