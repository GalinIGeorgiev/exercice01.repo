using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int biggestNumberOne = 0;
            int biggestNumberTwo = 0;
          //  bool noCombination = false;


            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int p = firstNumber; p <= secondNumber; p++)
                {
                    counter++;
                    if (i + p == magicNumber)
                    {
                        biggestNumberOne = i;
                        biggestNumberTwo = p;
                       // noCombination = true;
                    }
                }
            }
            if (biggestNumberOne + biggestNumberTwo == magicNumber)
            {
                Console.WriteLine($"Number found! {biggestNumberOne} + {biggestNumberTwo} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
