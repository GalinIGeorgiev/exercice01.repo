using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chooseDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffession = (Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());



            switch (proffession)
            {
                case "Athlete": Console.WriteLine($"The Athlete has to pay {quantity* 0.70:f2}."); break;

                case "Businesswoman": Console.WriteLine($"The Businesswoman has to pay {quantity * 1.00:f2}."); break;
                case "Businessman": Console.WriteLine($"The Businessman has to pay {quantity * 1.00:f2}."); break;
                case "SoftUni Student": Console.WriteLine($"The SoftUni Student has to pay {quantity * 1.70:f2}."); break;

                default: Console.WriteLine($"The {proffession} has to pay {quantity * 1.20:f2}."); break;
                
            }




        }
    }
}
