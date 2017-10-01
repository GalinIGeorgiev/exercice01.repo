using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution5CountOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text =(Console.ReadLine().Split(' ').ToArray());

            int[] numbers = new int[text.Length];
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                numbers[i] = int.Parse(text[i]);
                ;

                if (numbers[i] % 2 != 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
