using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class DatabaseLogSaver : ILogSaver 
    {
        public void SaveLog(Log log)
        {
            Console.WriteLine($"Saving log to DB. ${ log.LoggetAt} ${log.Message}");
        }

        public void SaveErrorLog(Log log)
        {
            Console.WriteLine($"Saving error log to DB. ${ log.LoggetAt} ${log.Message} ${log.ErrorStackTrace}");
        }
    }
}
