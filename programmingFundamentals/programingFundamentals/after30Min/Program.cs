using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace after30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int actualMinutes= minutes + 30;
            if (actualMinutes>=60)
            {
                actualMinutes -= 60;
                hours++;
            }

            if (hours >= 23)
            {
                hours = 00;
            }
            Console.WriteLine($"{hours}:{actualMinutes:d2}");

        }
    }
}
