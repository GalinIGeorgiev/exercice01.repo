using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
           double beatsPerMinute = double.Parse(Console.ReadLine());
           double beats = double.Parse(Console.ReadLine());

            double beatsPerSecond = (double)beatsPerMinute / 60;
            double secondsNeeded = beats / beatsPerSecond;
            double minutesNeeded = Math.Floor(secondsNeeded / 60);
            double bars = Math.Round(beats / 4.0,1);
            

            if (minutesNeeded < 1)
            {
                Console.WriteLine($"{bars} bars - {minutesNeeded}m {Math.Floor(secondsNeeded)}s");
            }
            else
            {
                double secondsOverMinuts = (secondsNeeded - (minutesNeeded * 60));
                Console.WriteLine($"{bars} bars - {minutesNeeded}m {Math.Floor(secondsOverMinuts)}s");
            }



            //  double beatsPerMinute = double.Parse(Console.ReadLine());
            //  double beats = double.Parse(Console.ReadLine());
            //  double perSecond = beatsPerMinute / 60;
            //  double bars =Math.Round (beats / 4,1);
            //  double barsTime = (beats / perSecond);
            //  double minutes =(barsTime / 60);
            //
            //
            //
            //  if (barsTime < 60)
            //  {
            //      Console.WriteLine($"{bars} bars - 0m {Math.Floor(barsTime)}s");
            //  }
            //  else if (barsTime >= 60)
            //  {
            //      double seconds =(barsTime - (minutes * 60.0));
            //      Console.WriteLine($"{bars} bars - {minutes}m {Math.Floor(seconds)}s");
            //      
            //  }
            //
            //
        }
    }
}
