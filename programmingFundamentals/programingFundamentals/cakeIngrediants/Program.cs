using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cakeIngrediants
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; ; i++)
            {
                string ingredients = Console.ReadLine();
                if (ingredients == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingredients}.");
                counter++;
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
