using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution16trickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string space = Console.ReadLine();
            int numberOFWords = int.Parse(Console.ReadLine());
            string sumOfStrings = "";
            for (int i = 0; i < numberOFWords; i++)
            {
                if (i != 0)
                {
                    sumOfStrings += space;
                }
                string word = Console.ReadLine();
                sumOfStrings += word;
            }

            Console.WriteLine(sumOfStrings);
        }
    }
}
