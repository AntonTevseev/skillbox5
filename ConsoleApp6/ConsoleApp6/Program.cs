using System;
using static System.Console;
namespace huy 
{ 
    class Program
    {
        static void Main(string[] ages)
        {
            Random r = new Random();
            int [] a = new int [5];
            int x = int.Parse(ReadLine());
            int z;
            for (int i = 0; i < a.Length; i++)
            {
                a [i] = r.Next(0,x);
                
                
            }
            while (true)
            {
                z = a[3];
                WriteLine("попробуйте угадать число из диапазона");
                int y = int.Parse(ReadLine());
                if (y > z)
                {
                    WriteLine("число меньше, вы не угадали");
                }
                else if (y < z)
                {
                    WriteLine("число больше, вы не угадали");
                }
                else if (y == z)
                {
                    WriteLine("вы угадали");
                    break;
                }
               
            }
        }
    }
}
