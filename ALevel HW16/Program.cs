using ALevel_HW16;

internal class Program
{
    private static void Main(string[] args)
    {
        MessageBox messageBox = new MessageBox();

        messageBox.WindowClosed += (sender, args) =>
        {
            if (args.state == State.Ok)
            {
                Console.WriteLine("Operation confirmed.");
            }
            else
            {
                Console.WriteLine("Operation rejected.");
            }
        };

        messageBox.Open();

        Console.ReadLine();
    }
}