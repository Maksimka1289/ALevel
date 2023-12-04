namespace ALevel_HW14.Delegate
{
    public class Calculator
    {
        public delegate int CalculatorDelegate(int firstValue, int secondValue);

        public event CalculatorDelegate CalculateEvent;
        public int Calculate(int firstValue, int secondValue) => firstValue + secondValue;
        public int ExecuteWithTryCatch(CalculatorDelegate calculatorDelegate, int firstValue, int secondValue)
        {
            try
            {
                return calculatorDelegate(firstValue, secondValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed: {ex.Message}");
                return 0;
            }
        }
    }
}
