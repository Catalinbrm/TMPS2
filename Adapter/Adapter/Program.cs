using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogSaver logSaver = new CloudLogSaverAdapter();

            Log simpleLog = new Log("Hello World");
            Log errorLog = new Log("Hello World !", "Exception message...");

            logSaver.SaveLog(simpleLog);
            logSaver.SaveErrorLog(errorLog);
        }
    }
}
