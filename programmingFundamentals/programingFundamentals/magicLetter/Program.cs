using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char missLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char p = firstLetter; p <= secondLetter; p++)
                {
                    for (char o = firstLetter; o <= secondLetter; o++)
                    {
                        if (i == missLetter || p == missLetter || o == missLetter)
                        {

                        }
                        else
                        {
                            Console.Write($"{i}{p}{o} ");
                        }
                    }
                }
            }
        }
    }
}
