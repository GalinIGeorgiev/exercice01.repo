using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3numbersProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double number = 1;
            for (int i = 1; i <= num; i++)
            {

                double number2 = double.Parse(Console.ReadLine());

                number =number* number2;


            }
            Console.WriteLine(number);
        }
    }
}
