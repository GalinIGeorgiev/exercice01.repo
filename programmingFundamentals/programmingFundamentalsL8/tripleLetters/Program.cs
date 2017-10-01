using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripleLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
        
            
            
           

            for (int i = 97; i < 97+number; i++)
            {
                for (int p = 97; p < 97+number; p++)
                {
                    for (int q = 97; q < 97+number; q++)
                    {

                        Console.Write($"{(char)i}{(char)p}{(char)q}\n");
                        
                    }
                }
            }
        }
    }
}
