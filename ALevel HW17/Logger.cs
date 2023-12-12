namespace ALevel_HW17
{
    public class Logger
    {
        private readonly List<string> logEntries = new List<string>();
        private int logCount = 0;
        private readonly int backupThreshold;
        private readonly string backupFolderPath;

        public event EventHandler BackupRequired;

        public Logger(int backupThreshold, string backupFolderPath)
        {
            this.backupThreshold = backupThreshold;
            this.backupFolderPath = backupFolderPath;

            if (!Directory.Exists(backupFolderPath))
            {
                Directory.CreateDirectory(backupFolderPath);
            }
        }

        public async Task LogAsync(string message)
        {
            logEntries.Add($"{DateTime.Now:s} - {message}");
            logCount++;

            if (logCount >= backupThreshold)
            {
                OnBackupRequired();

                logCount = 0;
            }
        }

        private void OnBackupRequired()
        {
            BackupRequired?.Invoke(this, EventArgs.Empty);
        }

        public async Task PerformBackupAsync()
        {
            string backupFileName = $"{DateTime.Now:yyyyMMddHHmmss}.log";
            string backupFilePath = Path.Combine(backupFolderPath, backupFileName);

            await File.WriteAllLinesAsync(backupFilePath, logEntries);

            Console.WriteLine($"Backup completed: {backupFilePath}");

            logEntries.Clear();
        }
    }
}
