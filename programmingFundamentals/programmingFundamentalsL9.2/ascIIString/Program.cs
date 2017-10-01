using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascIIString
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLetters; i++)
            {
                int number = int.Parse(Console.ReadLine());

                Console.Write($"{Convert.ToChar(number)}");

            }

        }
    }
}
