using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_HW5
{
    public sealed class Logger
    {
        private static Logger instance = null;
        private static readonly object padlock = new object();
        private string logs;

        private Logger()
        {
            logs = "";
        }

        public static Logger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

        public void Log(string logType, string message)
        {
            string log = $"{DateTime.Now}: {logType}: {message}";
            Console.WriteLine(log);
            logs += log + "\n";
        }

        public string GetLogs()
        {
            return logs;
        }
    }
}
