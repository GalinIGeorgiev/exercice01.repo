﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoHealth = 100;
            int goshoHealth = 100;
            
            

            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            for (int i = 1; ; i++)
            {
                

                if (i % 2 != 0)
                {

                    goshoHealth = goshoHealth - peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else if (i % 2 == 0)
                {
                    peshoHealth = peshoHealth - goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
               
               






                if (i % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }

            }
        }
    }
}
