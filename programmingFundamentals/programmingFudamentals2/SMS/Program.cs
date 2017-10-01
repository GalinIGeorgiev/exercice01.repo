using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());
            
            int numberToAddToSymbol = 0;
            int mainDigid = 0;
            int offset = 0;

            for (int i = 1; i <= numberOfLetters; i++)
            {
                int digids = int.Parse(Console.ReadLine());
                char firstSymbol = 'a';
                int digidLenght = 0;
                int startDigid = digids;
                numberToAddToSymbol = 0;
                startDigid = digids;
                mainDigid = 0;

                if (digids == 0)
                {
                    Console.Write(" ");
                }
                else if (digids % 10 >= 8)
                {
                    while (digids > 0)
                    {
                        digidLenght++;
                        digids = digids / 10;
                    }
                    mainDigid += startDigid % 10;
                    offset = (mainDigid - 2) * 3;

                    numberToAddToSymbol = offset + digidLenght ;

                    firstSymbol = (char)(firstSymbol + numberToAddToSymbol);
                    Console.Write($"{firstSymbol}");
                }
                else
                {
                    while (digids > 0)
                    {
                        digidLenght++;
                        digids = digids / 10;
                    }
                    mainDigid += startDigid % 10;
                    offset = (mainDigid - 2) * 3;

                    numberToAddToSymbol = offset + digidLenght - 1;

                    firstSymbol = (char)(firstSymbol+numberToAddToSymbol);
                    Console.Write($"{firstSymbol}");

                }
                
            }
           
        }
    }
}
