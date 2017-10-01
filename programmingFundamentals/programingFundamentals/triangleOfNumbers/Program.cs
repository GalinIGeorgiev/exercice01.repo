using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int printNumber = 0;
            for (int i = 1; i <= number; i++)
            {
                for (int p = 1; p <= i; p++)
                {
                    Console.Write($"{i}");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
