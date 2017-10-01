using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingHallequipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            int numberOfTools = int.Parse(Console.ReadLine());

            string nameOfTool = "";
            double priceOfTool = 0;
            int numberTheTool = 0;
            double moneySpend = 0;
            double balance = 0;
            balance = budged;

       //   if (Galin.EndsWith("y"))
       //   {
       //       Galin = Galin.Remove(Galin.Length - 1);
       //       Galin += "ies";
       //   }
       //   else if (Galin.EndsWith("o") ||
       //            Galin.EndsWith("s") ||
       //            Galin.EndsWith("ch") ||
       //            Galin.EndsWith("sh") ||
       //            Galin.EndsWith("x") ||
       //            Galin.EndsWith("z"))
       //   {
       //       Galin = Galin + "es";
       //   }
       //   else
       //   {
       //       Galin = Galin + "s";
       //   }
            for (int i = 1; i <= numberOfTools; i++)
            {
                nameOfTool = Console.ReadLine();
                priceOfTool = double.Parse(Console.ReadLine());
                numberTheTool = int.Parse(Console.ReadLine());


                moneySpend += (priceOfTool * numberTheTool);
                budged -= (priceOfTool * numberTheTool);


                if (numberTheTool > 1)
                {
                    if (nameOfTool.EndsWith("s") || nameOfTool.EndsWith("ch") || nameOfTool.EndsWith("sh") || nameOfTool.EndsWith("o") || nameOfTool.EndsWith("z") || nameOfTool.EndsWith("x"))
                    {
                        nameOfTool = nameOfTool + "es";
                        Console.WriteLine($"Adding {numberTheTool} {nameOfTool} to cart.");
                    }                
                    else if (nameOfTool.EndsWith("y"))
                    {
                        nameOfTool= nameOfTool.Remove(nameOfTool.Length-1);
                        nameOfTool = nameOfTool + "ies";
                        Console.WriteLine($"Adding {numberTheTool} {nameOfTool} to cart.");
                    }
                    else
                    {
                        Console.WriteLine($"Adding {numberTheTool} {nameOfTool}s to cart.");
                    }

                }
                else
                {
                    Console.WriteLine($"Adding {numberTheTool} {nameOfTool} to cart.");
                }


            }
            if (budged < 0)
            {
                Console.WriteLine($"Subtotal: ${moneySpend:f2}");
                Console.WriteLine($"Not enough. We need ${-(budged):f2} more.");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${moneySpend:f2}");
                Console.WriteLine($"Money left: ${budged:f2}");
            }
            

        }
    }
}
