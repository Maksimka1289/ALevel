using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;

namespace ALevel_HW9
{
    public class FileService
    {
        private const string LogDirectory = "Logs";
        private const string JsonFileName = "log.json";

        public static void WriteToFile(string log)
        {
            string fileName = $"{DateTime.Now:MM_dd_yyyy_hh_mm_ss_fff_tt}.txt";
            string filePath = Path.Combine(LogDirectory, fileName);

            if (!Directory.Exists(LogDirectory))
            {
                Directory.CreateDirectory(LogDirectory);
            }

            File.AppendAllText(filePath, log + Environment.NewLine);

            LogEntry logEntry = new LogEntry
            {
                LogTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"),
                LogType = log.Split(':')[1].Trim(),
                Message = log.Split(':')[2].Trim()
            };

            string jsonLog = JsonConvert.SerializeObject(logEntry);
            File.AppendAllText(Path.Combine(LogDirectory, JsonFileName), jsonLog + Environment.NewLine);

            DeleteOldestFiles();
        }

        private static void DeleteOldestFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(LogDirectory);
            FileInfo[] files = directory.GetFiles();

            if (files.Length > 3)
            {
                FileInfo oldestFile = files.OrderBy(f => f.CreationTime).First();
                oldestFile.Delete();
            }
        }
    }

}
