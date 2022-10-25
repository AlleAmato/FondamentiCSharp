using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void LogMessage<T>(T message);

    internal class Logger<T>
    {
        private LogMessage<T> _logger;

        public Logger(LogMessage<T> logger)
        {
            _logger = logger;
        }

        public void Log(T message)
        {
            //Console.WriteLine(message);
            _logger(message);
        }
    }
}
