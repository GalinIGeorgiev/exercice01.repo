﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bavarageLebels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = (Console.ReadLine());
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{(energy*volume)/100}kcal, {(sugar*volume)/100}g sugars");

        }
    }
}
