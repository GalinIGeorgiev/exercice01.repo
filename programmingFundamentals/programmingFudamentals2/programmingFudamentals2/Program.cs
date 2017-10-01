using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmingFudamentals2
{
    class Program
    {
        static void Main(string[] args)
        {

                int number = int.Parse(Console.ReadLine());
            //     int spaceNumber = 0;
            //     int spaceMiddleNumber = number - 2;
            //
            //     // topHalf
            //     for (int i = 1; i <= number / 2; i++)
            //     {
            //         Console.Write(new string(' ', spaceNumber));
            //         Console.Write('x');
            //         Console.Write(new string(' ', spaceMiddleNumber));
            //         Console.Write('x');
            //         Console.WriteLine(new string(' ', spaceNumber));
            //
            //         spaceNumber++;
            //         spaceMiddleNumber -= 2;
            //     }
            //
            //     //middle
            //     Console.Write(new string(' ', number / 2));
            //     Console.Write('x');
            //     Console.WriteLine(new string(' ', number / 2));
            //
            //     //bottomHalf
            //     int spaceMiddleSecond = 1;
            //     int spaceSecond = (number - 3) / 2;
            //
            //
            //     for (int i = 1; i <= number / 2; i++)
            //     {
            //         Console.Write(new string(' ', spaceSecond));
            //         Console.Write('x');
            //         Console.Write(new string(' ', spaceMiddleSecond));
            //         Console.Write('x');
            //         Console.WriteLine(new string(' ', spaceSecond));
            //
            //         spaceSecond--;
            //         spaceMiddleSecond += 2;
            //     }
            //     

            for (int i = 1; i <= number; i++)
            {
                for (int p = 1; p <= number; p++)
                {
                    if (p == i)
                    {
                        Console.Write('x');
                    }
                    else if (p == number + 1 - i)
                    {
                        Console.Write('x');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                   
                }
                Console.WriteLine();
            }
            
        }
    }
}
