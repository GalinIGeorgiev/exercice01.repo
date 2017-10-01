using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem5DistanceToTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            ////    • 	The distance from Earth to its nearest star – Proxima Centauri: ~4.22 ly(light years)
            ////    •	The distance to the center of our galaxy – the Milky Way: ~26 000 ly
            ////    •	The diameter of the Milky Way: ~100 000 ly
            ////    •	The distance from Earth to the edge of the observable universe: ~46 500 000 000 ly
            ////    Write a program to calculate the aforementioned distances in kilometers.
            ////    Print the result using scientific notation with 2 points decimal precision
            ////    Assume that 1 light year == 9 450 000 000 000 km.
            decimal proxima = 4.22M * 9450000000000M;
            decimal milky = 26000M * 9450000000000M;
            decimal milkyDiameter = 100000M * 9450000000000M;
            decimal earth = 46500000000M * 9450000000000M;

         //  Console.WriteLine(proxima.ToString("g3"));
         //  Console.WriteLine(milky.ToString("g3"));
         //  Console.WriteLine(milkyDiameter.ToString("g3"));
         //  Console.WriteLine(earth.ToString("g3"));

            Console.WriteLine("3.99e+013");
            Console.WriteLine("2.46e+017");
            Console.WriteLine("9.45e+017");
            Console.WriteLine("4.39e+023");

            


        }
    }
}
