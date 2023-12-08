class Program
{
    public static async Task Main()
    {
        string result = await ReadAndConcatenateAsync();

        Console.WriteLine(result);
    }

    static async Task<string> ReadFileAsync(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            return await reader.ReadToEndAsync();
        }
    }

    static async Task<string> ReadAndConcatenateAsync()
    {
        Task<string> helloTask = ReadFileAsync("Hello.txt");
        Task<string> worldTask = ReadFileAsync("World.txt");

        await Task.WhenAll(helloTask, worldTask);

        string concatenatedResult = $"{await helloTask} {await worldTask}";

        return concatenatedResult;
    }
}
