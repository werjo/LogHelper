using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LH.Core.Logging
{
    public interface ILog
    {
        /// <summary>
        /// Log debug message with exception
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="msg">The message.</param>
        /// <param name="e">The exception</param>
        void D(string tag, string msg, Exception e);
        /// <summary>
        /// Log debug message
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="msg">The message.</param>
        void D(string tag, string msg);
        /// <summary>
        /// Log information with exception
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="msg">The message.</param>
        /// <param name="e">The exception.</param>
        void I(string tag, string msg, Exception e);
        /// <summary>
        /// Log information 
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="msg">The message.</param>
        void I(string tag, string msg);
        /// <summary>
        /// Log warning with exception
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="msg">The message.</param>
        /// <param name="e">The exception.</param>
        void W(string tag, string msg, Exception e);
        /// <summary>
        /// Log warning
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="msg">The message.</param>
        void W(string tag, string msg);
        /// <summary>
        /// Log error with exception
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="msg">The message.</param>
        /// <param name="e">The exception.</param>
        void E(string tag, string msg, Exception e);
        /// <summary>
        /// Log error
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="msg">The message.</param>
        void E(string tag, string msg);
    }
}
