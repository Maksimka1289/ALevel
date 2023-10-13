using System;


class Program
{
    static void Main()
    {
        int[] A = new int[20];
        int[] B = new int[20];

        Random random = new Random();
        int Min = 1;
        int Max = 1000;

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = random.Next(Min, Max);
        }

        int index = 0;
        for(int i = 0;i < A.Length; i++)
        {
            if (A[i] < 888)
            {
                B[index] = A[i];
                index++;
            }
        }

        Array.Sort(B, (a, b) => b.CompareTo(a));

        for(int i = 0; i < index; i++)
        {
            Console.WriteLine($"Elements B: {B[i]}");
        }


    }
}