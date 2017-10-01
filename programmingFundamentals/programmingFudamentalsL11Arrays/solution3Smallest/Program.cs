using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution3Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();          
            string[] numberTokens = input.Split(' ');
            double[] numbersDouble = new double[numberTokens.Length];

            double smallestNumber = double.MaxValue;

            for (int i = 0; i < numbersDouble.Length; i++)
            {
                numbersDouble[i] = double.Parse(numberTokens[i]);
                
            }

            for (int i = 0; i < numbersDouble.Length; i++)
            {

                if (numbersDouble[i] <= smallestNumber)
                {
                    smallestNumber = numbersDouble[i];
                }

            }
            Console.WriteLine(smallestNumber);
            
        }
    }
}
