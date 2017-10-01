using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; ; i++)
            {

                try
                {
                    int name = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch
                {

                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
