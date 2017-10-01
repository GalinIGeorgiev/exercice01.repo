using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOne = int.Parse(Console.ReadLine());
            int NumberTwo = int.Parse(Console.ReadLine());
            int MaxNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int i = NumberOne; i >= 1; i--)
            {
                for (int p = 1; p <= NumberTwo; p++)
                {
                    if (sum >= MaxNumber)
                    {
                        break;
                    }
                    sum += (3 * (i * p));
                    counter++;
                }
            }
            if (sum >= MaxNumber)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} >= {MaxNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} ");
            }

        }
    }
}
