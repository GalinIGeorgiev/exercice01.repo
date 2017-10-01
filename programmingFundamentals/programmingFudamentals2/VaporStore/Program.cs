using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string game = "";
            double OutFall4 = 39.99;
            double CSOG = 15.99;
            double ZplinterZell = 19.99;
            double Honored2 = 59.99;
            double RoverWatch = 29.99;
            double RoverWatchOriginsEdition = 39.99;
            double moneySpend = 0;

            do
            {
                game = Console.ReadLine();

                switch (game)
                {
                    case "OutFall 4":
                        if (money >= OutFall4)
                        { money -= 39.99; moneySpend += 39.99; Console.WriteLine($"Bought {game}"); }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "CS: OG":
                        if (money >= CSOG) { money -= 15.99; moneySpend += 15.99; Console.WriteLine($"Bought {game}"); }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Zplinter Zell":
                        if (money >= ZplinterZell) { money -= 19.99; moneySpend += 19.99; Console.WriteLine($"Bought {game}"); }                       
                                              else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Honored 2":
                        if (money >= Honored2) { money -= 59.99; moneySpend += 59.99; Console.WriteLine($"Bought {game}"); }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;


                    case "RoverWatch":
                        if (money >= RoverWatch) { money -= 29.99; moneySpend += 29.99; Console.WriteLine($"Bought {game}"); }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        } break;


                    case "RoverWatch Origins Edition":
                        if (money >= RoverWatchOriginsEdition) { money -= 39.99; moneySpend += 39.99; Console.WriteLine($"Bought {game}"); }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        } break;
                    case "Game Time": break; 


                    default: Console.WriteLine("Not Found"); break;

                }


                if (money == 0) Console.WriteLine("Out of money!");
                if (game == "Game Time") break;

            } while (money > 0);

          if (money>0)  Console.WriteLine($"Total spent: ${moneySpend:f2}. Remaining: ${(money):f2}");
        }
    }
}
