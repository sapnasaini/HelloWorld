using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorldCommon.Services
{
    using System;
    using System.Collections.Generic;
     interface IConsoleLog
    {
        /// <summary>
        ///     Write an ERROR message to the log
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="otherProperties">Other properties</param>
        /// <param name="exception">Exception instance</param>
        void Error(string message, Dictionary<string, object> otherProperties, Exception exception);
    }
}
