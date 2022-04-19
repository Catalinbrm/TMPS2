using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CloudLogSaver
    {
        public void Save(DateTime loggetAt, string message)
        {
            Console.WriteLine($"Saving log to Cloud. {loggetAt} {message}");
        }

        public void SaveException(DateTime loggetAt, string message, string error)
        {
            Console.WriteLine($"Saving error log to Cloud. {loggetAt} {message} {error}");
        }
    }
}
