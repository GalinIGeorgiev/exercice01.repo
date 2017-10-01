using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution10DataOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal first = decimal.Parse(Console.ReadLine());
            decimal second = decimal.Parse(Console.ReadLine());
            decimal firstOriginal = first;
            decimal secondOriginal = second;
            string smallertypeFirst = " ";
            string biggertypeFirst = " ";
            string smallertypeSecond = " ";
            string biggertypeSecond = " ";




            if (first <= byte.MaxValue)
            {
                first = byte.MaxValue;
                biggertypeFirst = "byte";
                smallertypeFirst = "byte";
            }
            else if (ushort.MinValue <= first && first <= ushort.MaxValue)
            {
                first = ushort.MaxValue;
                biggertypeFirst = "ushort";
                smallertypeFirst = "ushort";
            }
            else if (uint.MinValue <= first && first <= uint.MaxValue)
            {
                first = uint.MaxValue;
                biggertypeFirst = "uint";
                smallertypeFirst = "uint";
            }
            else if (ulong.MinValue <= first && first <= ulong.MaxValue)
            {
                first = ulong.MaxValue;
                biggertypeFirst = "ulong";
                smallertypeFirst = "ulong";
            }

            // second number 
            if (second <= byte.MaxValue)
            {
                second = byte.MaxValue;
                smallertypeSecond = "byte";
                biggertypeSecond = "byte";
            }
            else if (ushort.MinValue <= second && second <= ushort.MaxValue)
            {
                second = ushort.MaxValue;
                biggertypeSecond = "ushort";
                smallertypeSecond = "ushort";
            }
            else if (uint.MinValue <= second && second <= uint.MaxValue)
            {
                second = uint.MaxValue;
                biggertypeSecond = "uint";
                smallertypeSecond = "uint";
            }
            else if (ulong.MinValue <= second && second <= ulong.MaxValue)
            {
                second = ulong.MaxValue;
                biggertypeSecond = "ulong";
                smallertypeSecond = "ulong";
            }

            if (firstOriginal > secondOriginal)
            {
                decimal timesOverflow =Math.Round(firstOriginal / second,0);
                Console.WriteLine($"bigger type: {biggertypeFirst}");
                Console.WriteLine($"smaller type: {smallertypeSecond}");
                Console.WriteLine($"{firstOriginal} can overflow {smallertypeSecond} {timesOverflow} times");
            }
            else
            {
                decimal timesOverflow =Math.Round(secondOriginal / first,0);
                Console.WriteLine($"bigger type: {biggertypeSecond}");
                Console.WriteLine($"smaller type: {smallertypeFirst}");
                Console.WriteLine($"{secondOriginal} can overflow {smallertypeFirst} {timesOverflow} times");
            }

        }


    }
}

