using System;
using System.Net.Http.Headers;

class Program
{
    public static void Main()
    {
        int lenghtArray;
        int i;

        do
        {
            Console.Write("Введите размер массива: ");
        }
        while (!int.TryParse(Console.ReadLine(), out lenghtArray));

        int[] mainArray = new int[lenghtArray];

        Random rand = new Random();

        for (i = 0; i < mainArray.Length; i++)
        {
            mainArray[i] = rand.Next(1, 27);
        }

        int indexEvenElements = 0;
        int indexOddElements = 0;
        int[] allElementsArray = new int[lenghtArray];
        int[] evenArray = new int[lenghtArray];
        int[] oddArray = new int[lenghtArray];
        char[] convertedEvenNumber = new char[lenghtArray];
        char[] convertedOddNumber = new char[lenghtArray];
        for (i = 0; i < lenghtArray; i++)
        {
            allElementsArray[i] = rand.Next(97, 123);
        }

        for (i = 0; i < lenghtArray; i++)
        {
            if ((allElementsArray[i] % 2) == 0)
            {
                evenArray[i] = allElementsArray[i];
            }
        }

        for (i = 0; i < lenghtArray; i++)
        {
            convertedEvenNumber[i] = (char)evenArray[i];
        }

        Console.Write("Буквы переведённые из массива чётных чисел: ");
        for (i = 0; i < lenghtArray; i++)
        {
            if (convertedEvenNumber[i] == 'a' || convertedEvenNumber[i] == 'e'
                || convertedEvenNumber[i] == 'i' || convertedEvenNumber[i] == 'd'
                || convertedEvenNumber[i] == 'h' || convertedEvenNumber[i] == 'j')
            {
                convertedEvenNumber[i] = char.ToUpper(convertedEvenNumber[i]);
                indexEvenElements++;
            }

            Console.Write($"{convertedEvenNumber[i]}, ");
        }

        Console.WriteLine();

        for (i = 0; i < lenghtArray; i++)
        {
            if ((allElementsArray[i] % 2) != 0)
            {
                oddArray[i] = allElementsArray[i];
            }
        }

        for (i = 0; i < lenghtArray; i++)
        {
            convertedOddNumber[i] = (char)oddArray[i];
        }

        Console.Write("Буквы переведённые из массива нечётных чисел: ");
        for (i = 0; i < lenghtArray; i++)
        {
            if (convertedOddNumber[i] == 'a' || convertedOddNumber[i] == 'e'
                || convertedOddNumber[i] == 'i' || convertedOddNumber[i] == 'd'
                || convertedOddNumber[i] == 'h' || convertedOddNumber[i] == 'j')
            {
                convertedOddNumber[i] = char.ToUpper(convertedOddNumber[i]);
                indexOddElements++;
            }

            Console.Write($"{convertedOddNumber[i]}, ");
        }

        Console.WriteLine();

        if (indexEvenElements > indexOddElements)
        {
            Console.WriteLine("В массиве чётных елементов заглавных букв больше чем в массиве нечётных елементов");
        }
        else if (indexEvenElements < indexOddElements)
        {
            Console.WriteLine("В массиве нечётных елементов заглавных букв больше чем в массиве чётных елементов");
        }
        else if (indexEvenElements == indexOddElements)
        {
            Console.WriteLine("Количество заглавных букв в массивах одинаковое");
        }

        Console.WriteLine($"Размер массивa: {lenghtArray}");
        Console.ReadKey();
    }
}