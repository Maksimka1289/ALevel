using ALevel_HW11;

public class Program
{
    static void Main()
    {
        CustomCollection<int> customCollection = new CustomCollection<int>();

        customCollection.Add(3);
        customCollection.Add(1);
        customCollection.Add(2);

        foreach (var item in customCollection)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Count: " + customCollection.Count);

        customCollection.Sort();
        Console.WriteLine("Sorted Collection:");
        foreach (var item in customCollection)
        {
            Console.WriteLine(item);
        }

        customCollection.SetDefaultAt(1, 10);
        Console.WriteLine("After setting default at index 1:");
        foreach (var item in customCollection)
        {
            Console.WriteLine(item);
        }
    }
}