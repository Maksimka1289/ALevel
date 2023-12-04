using ALevel_HW14.Delegate;
using ALevel_HW14.LINQ;

public class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();

        calculator.CalculateEvent += (a, b) =>
        {
            int sum = a + b;
            Console.WriteLine($"First result: {sum}");
            return sum;
        };
        calculator.CalculateEvent += (a, b) =>
        {
            int sum = a + b;
            Console.WriteLine($"Second result: {sum}");
            return sum;
        };

        int sum = calculator.ExecuteWithTryCatch(calculator.Calculate, 5, 7) + calculator.ExecuteWithTryCatch(calculator.Calculate, 10, 7);

        Console.WriteLine($"Finale result: {sum}");

        List<Contact> contacts = new List<Contact>
        {
            new Contact{Name = "Maksim", Age = 18},
            new Contact{Name = "Vlad", Age = 25},
            new Contact{Name = "Bob", Age = 15}
        };

        //FirstOrDefault
        Contact contact = contacts.FirstOrDefault();
        Console.WriteLine($"First contact: {contact?.Name ?? "No contacts"}");

        //Where
        var adults = contacts.Where(x => x.Age > 15);
        Console.WriteLine($"Adult: ");
        foreach(var counter in adults)
        {
            Console.WriteLine($"{counter.Name}, Age: {counter.Age}");
        }

        //Select
        var nameOnly = contacts.Select(x => x.Name);
        Console.WriteLine("Names only: ");
        foreach(var counter in nameOnly)
        {
            Console.WriteLine(counter);
        }

        //OrderBy
        var orderByName = contacts.OrderBy(x  => x.Name);
        Console.WriteLine("Ordered by Name:");
        foreach (var counter in orderByName)
        {
            Console.WriteLine(counter.Name, counter.Age);
        }

        //Skip
        var skip = contacts.Skip(2);
        Console.WriteLine("Skiped: ");
        foreach (var counter in skip)
        {
            Console.WriteLine(counter.Name, counter.Age);
        }

        //Take
        var take = contacts.Take(2);
        Console.WriteLine("Taked: ");
        foreach( var counter in take)
        {
            Console.WriteLine(counter.Name, counter.Age);
        }
    }
}