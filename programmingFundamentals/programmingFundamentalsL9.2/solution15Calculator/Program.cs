using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution15Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            string operatorr = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());


                switch (operatorr)
            {
                case "+": Console.WriteLine($"{first} + {second} = {first+second}"); break;
                case "-": Console.WriteLine($"{first} - {second} = {first - second}"); break;
                case "*": Console.WriteLine($"{first} * {second} = {first * second}"); break;
                case "/": Console.WriteLine($"{first} / {second} = {first / second}"); break;
            }



        }
    }
}
