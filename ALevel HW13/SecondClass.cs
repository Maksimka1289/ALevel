using System.Net.WebSockets;

namespace ALevel_HW13
{
    public class SecondClass
    {
        public delegate int MultiplyDelegate(int firstValue, int secondValue);

        public delegate bool ResultDelegate(int value);

        public ResultDelegate Calc(MultiplyDelegate multiplyDelegate, int num1, int num2)
        {
            int result = multiplyDelegate(num1, num2);

            ResultDelegate resultDelegate = (num) => Result(result, num);

            return resultDelegate;
        }

        public bool Result(int value, int num)
        {
            bool isDivision = false;
            if(value % num == 0)
            {
                isDivision = true;
            }

            return isDivision;
        }
    }
}
