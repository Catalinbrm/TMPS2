using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface ILogSaver
    {
        public void SaveLog(Log log);
        public void SaveErrorLog(Log log);
    }
}
