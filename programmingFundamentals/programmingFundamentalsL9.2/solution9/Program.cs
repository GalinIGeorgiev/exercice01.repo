using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());




            if (a > 0 && b > 0 && c > 0)
            {
                if ((a * a) + (b * b) == c * c)
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine($"Triangle has a right angle between sides a and b");
                }
                else if ((a * a) + (c * c) == b * b)
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine($"Triangle has a right angle between sides a and c");
                }
                else if ((c * c) + (b * b) == a * a)
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine($"Triangle has a right angle between sides b and c");
                }
                else
                {
                    if ((a + b > c) && (b + c > a) && (a + c > b))
                    {
                        Console.WriteLine("Triangle is valid.");
                        Console.WriteLine($"Triangle has no right angles");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Triangle.");
                    }

                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }


        }
    }
}


