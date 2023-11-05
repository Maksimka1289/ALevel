using ALevel_HW7.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Maksym Duzhyi", 18);
        person.DisplayInfo();

        Console.WriteLine();

        Teacher teacher = new Teacher("Petro Chernych", 25, "Teacher", ".Net/C#");
        teacher.DisplayInfo();

        Console.WriteLine();

        NonTeachingStaff nonTeachingStaff = new NonTeachingStaff("John Weak", 32, "Cleaner", "Caretaker");
        nonTeachingStaff.DisplayInfo();

        Console.WriteLine();

        Student srudent = new Student("Melisa Jenson", 24, 8);
        srudent.DisplayInfo();

        Console.WriteLine();

        Course course = new Course(".Net/C#", 9);
        course.DisplayInfo();
    }
}