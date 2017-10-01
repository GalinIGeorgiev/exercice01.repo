using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem8TravelingLightSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal years = decimal.Parse(Console.ReadLine());

            decimal distance = 9450000000000 * years;

            decimal seconds = distance / 300000m;


            int minutes = (int)(seconds / 60);

            int hours = (minutes / 60);

            int days = (hours / 24);

            int weeks = (days / 7);
            seconds %= 60;
            minutes %= 60;
            hours %= 24;
            days %= 7;
            Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{days} days");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
            Console.WriteLine($"{Math.Floor(seconds)} seconds");







        }
    }
}
