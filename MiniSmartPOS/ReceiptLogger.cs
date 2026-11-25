using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSmartPOS
{
    internal class ReceiptLogger
    {
        public delegate void LogDelegate(string message);

        private LogDelegate _logAction;

        public ReceiptLogger(LogDelegate LogAction)
        {
            _logAction = LogAction;
        }

        public void Log(string Message)
        {
            _logAction?.Invoke(Message);
        }
    }
}
