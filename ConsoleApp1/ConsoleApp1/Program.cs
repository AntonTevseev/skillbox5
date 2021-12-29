using System;
using static System.Console;
namespace xuy
{
    class Program
    {
        static void Main(string[] ages)
        {
            Random random = new Random();
            int x = int.Parse(ReadLine());
            int y = int.Parse(ReadLine());
            int[,]a = new int[x, y];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(1,5);
                    sum += a[i, j];
                    Write($"{a[i, j], 2}");
                }
                WriteLine($" :{sum}");
            }
        }
    }
}