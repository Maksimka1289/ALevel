using System.Data;

namespace ALevel_HW9
{
    public class Logger
    {
        private static readonly object lockObj = new object();

        public static void Log(string logType, string message)
        {
            string logTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt");
            string log = $"{logTime}: {logType}: {message}";

            lock (lockObj)
            {
                Console.WriteLine(log);
                FileService.WriteToFile(log);
            }
        }
    }
}
