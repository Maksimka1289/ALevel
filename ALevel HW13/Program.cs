using ALevel_HW13;
using static ALevel_HW13.FirstClass;
using static ALevel_HW13.SecondClass;

internal class Program
{
    private static void Main(string[] args)
    {
        FirstClass firstClass = new FirstClass();
        SecondClass secondClass = new SecondClass();

        FirstDelegate firstDelegate = Show;

        ResultDelegate resultDelegate = secondClass.Calc(firstClass.Multiply, 10, 2);

        firstDelegate(resultDelegate(5));
    }

    public static void Show(bool result) => Console.WriteLine(result);
}