using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
           string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthBar = int.Parse(Console.ReadLine());
            int stamina = int.Parse(Console.ReadLine());
            int staminaBar = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name} ");
            Console.Write("Health: ");
            Console.Write(new string('|',1));
            Console.Write(new string('|', health));
            Console.Write(new string('.', healthBar-health));
            Console.WriteLine(new string('|', 1));
            Console.Write("Energy: ");
            Console.Write(new string('|', 1));
            Console.Write(new string('|', stamina));
            Console.Write(new string('.', staminaBar-stamina));
            Console.WriteLine(new string('|', 1));
        }
    }
}
