using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());

            double miles = km * 1.60934;
            Console.WriteLine($"{miles:f2}");
        }
    }
}
