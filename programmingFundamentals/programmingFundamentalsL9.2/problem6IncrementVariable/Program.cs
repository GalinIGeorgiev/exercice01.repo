using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem6IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int name = int.Parse(Console.ReadLine());
            byte a = 0;
            for (int i = 0; i < name; i++)
            {
                a++;
            }
            int times = name / 256;

            if (a < name)
            {
                Console.WriteLine(a);
                Console.WriteLine($"Overflowed {times} times");
            }
            else
            {
                Console.WriteLine(a);
            }
            

        }
    }
}
