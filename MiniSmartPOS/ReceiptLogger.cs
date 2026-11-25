using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSmartPOS
{
    internal class ReceiptLogger
    {
       public Action<string> _logAction;
        public ReceiptLogger(Action<string> LogAction)
        {
            _logAction = LogAction;
        }

        public void Log(string Message)
        {
            _logAction?.Invoke(Message);
        }
    }
}
