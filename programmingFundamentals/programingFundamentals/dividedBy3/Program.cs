using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividedBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            for (int i =1; i <= 100; i+=2)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    counter++;
                }
                if (counter == number)
                {
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
            }
        }
    }
}
