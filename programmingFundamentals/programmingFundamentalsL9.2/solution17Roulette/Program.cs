using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution17Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            bool IsREversed = false;
            string message = "";
            string currentword = "";
            string previousWord = "";

            for (int i = 0; i < numberOfWords;)
            {
                previousWord = currentword;
                currentword = Console.ReadLine();
                if (previousWord == currentword)
                {

                    if (currentword == "spin")
                    {
                        IsREversed = !IsREversed;
                        message = String.Empty;
                    }
                    else
                    {
                        message = String.Empty;
                        i++;
                        continue;
                    }
                    
                                  
                }
                if (currentword == "spin")
                {
                    IsREversed = !IsREversed;

                }
                else
                {
                    if (IsREversed)
                    {
                        message = currentword + message;
                        i++;
                    }
                    else
                    {
                        message += currentword;
                        i++;
                        
                    }
                }            
            }
            Console.WriteLine(message);



        }
    }
}
