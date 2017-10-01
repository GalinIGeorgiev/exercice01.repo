using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmingFudamentalsL11Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                sum += array[i];
                

            }
            Console.WriteLine(sum);


        }
    }
}
