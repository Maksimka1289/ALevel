using System;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        
        int[] massiv = { -40, 50, 60, 150, 200, 4, -120, 5 };
        for(int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > -100 && massiv[i] < 100)
            {
                Console.WriteLine(massiv[i]);
            }
        }
    }
}

    
