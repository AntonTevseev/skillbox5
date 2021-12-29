using System;
using static System.Console;
namespace xuy
{
    class Program
    {
        static void Main(string[]ages)
        {
            int a = int.Parse(Console.ReadLine());

            int[] myArray = new int[a];
            int k = 0;
            while (k < a)
            {
                Console.Write($"Введите число под номером {k + 1} : ");
                myArray[k] = int.Parse(Console.ReadLine());
                k++;
            }

            int min = int.MaxValue;
            for (int l = 0; l < myArray.Length; l++)
            {
                if (myArray[l] < min)
                {
                    min = myArray[l];
                }
            }
            Console.WriteLine($"Миниммальное число = {min}");
            Console.Write("Последовательность : ");

            for (int n = 0; n < myArray.Length; n++)
            {
                Console.Write($"{myArray[n]}, ");
            }

        }
    }
}