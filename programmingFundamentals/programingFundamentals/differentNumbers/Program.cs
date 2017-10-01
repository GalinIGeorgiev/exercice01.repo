using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace differentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = n1; i <= n2; i++)
            {
                for (int p = n1; p <= n2; p++)
                {
                    for (int q = n1; q <= n2; q++)
                    {
                        for (int o = n1; o <= n2; o++)
                        {
                            for (int l = n1; l <= n2; l++)
                            {
                                if (n1 <= i && i < p && p < q && q < o && o < l && l <= n2)
                                {
                                    Console.WriteLine($"{i} {p} {q} {o} {l} ");
                                    counter++;
                                }
                            }

                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
