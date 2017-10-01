using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution2Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double multiply = double.Parse(Console.ReadLine());

            string[] numberTokens = input.Split(' ');
            double[] numbersDouble = new double[numberTokens.Length];
            

            for (int i = 0; i < numbersDouble.Length; i++)
            {
                numbersDouble[i] = double.Parse(numberTokens[i]);
                numbersDouble[i] = numbersDouble[i] * multiply;
            }


            for (int i = 0; i < numbersDouble.Length; i++)
            {
                Console.Write(numbersDouble[i]+" ");
            }
            
        }
    }
}
