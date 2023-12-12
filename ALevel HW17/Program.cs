using ALevel_HW17;
using Newtonsoft.Json;
internal class Program
{
    static async Task Main()
    {
        var config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));

        var logger = new Logger(config.BackupThreshold, config.BackupFolderPath);

        logger.BackupRequired += async (sender, args) => await logger.PerformBackupAsync();

        var task1 = Task.Run(async () => await LogEntriesAsync(logger, 50));
        var task2 = Task.Run(async () => await LogEntriesAsync(logger, 50));

        await Task.WhenAll(task1, task2);
    }

    static async Task LogEntriesAsync(Logger logger, int count)
    {
        for (int i = 1; i <= count; i++)
        {
            await logger.LogAsync($"Log entry {i}");
            Thread.Sleep(50);
        }
    }
}