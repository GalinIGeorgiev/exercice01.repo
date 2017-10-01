using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnaSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string A = "A";
            
            string A2 = "A";
            string A3 = "A";



            for (int i = 1; i <= 4; i++)
            {
                if (i == 1) { A = "A"; }
                if (i == 2) { A = "C"; }
                if (i == 3) { A = "G"; }
                if (i == 4) { A = "T"; }
                for (int p = 1; p <= 4; p++)
                {
                    Console.WriteLine();

                    if (p == 1) { A2 = "A"; }
                    if (p == 2) { A2 = "C"; }
                    if (p == 3) { A2 = "G"; }
                    if (p == 4) { A2 = "T"; }
                    for (int q = 1; q <= 4; q++)
                    {
                        if (q == 1) { A3 = "A"; }
                        if (q == 2) { A3 = "C"; }
                        if (q == 3) { A3 = "G"; }
                        if (q == 4) { A3 = "T"; }


                        if (i + p + q >= number)
                        {
                            Console.Write('O');
                            Console.Write($"{A}{A2}{A3}");
                            Console.Write("O ");
                        }
                        else
                        {
                            Console.Write('X');
                            Console.Write($"{A}{A2}{A3}");
                            Console.Write("X ");
                        }




                        
                    }
                }
                
            }

        }
    }
}
