using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startNumber = 0;
            int sum = 0;
            int num2 = 1;

            for (int counter = 1; counter <= number; counter++)
            {
                startNumber = counter;
                num2 = 1;
                sum = 0;
                while (startNumber > 0)
                {
                    num2 = startNumber % 10;
                    startNumber = startNumber / 10;
                    sum += num2;


                }
                if (sum == 5 || sum == 7 || sum == 11) { Console.WriteLine($"{counter} -> True"); }
                else
                {
                    Console.WriteLine($"{counter} -> False");
                }
            }

        }
    }
}
