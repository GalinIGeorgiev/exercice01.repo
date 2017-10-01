    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace problem7Terabytes
    {
        class Program
        {
            static void Main(string[] args)
            {
                decimal number = decimal.Parse(Console.ReadLine());

                number = number * 1024 * 1024 * 1024 * 1024 * 8;
                Console.WriteLine($"{number:f0}");

            }
        }
    }
