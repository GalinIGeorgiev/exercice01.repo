using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int name = int.Parse(Console.ReadLine());
            int dateTaken1 = int.Parse(Console.ReadLine());
            int dateTaken2 = int.Parse(Console.ReadLine());
            int dateTaken3 = int.Parse(Console.ReadLine());
            int timeHours = int.Parse(Console.ReadLine());
            int timeMinutes = int.Parse(Console.ReadLine());
            double bytes = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string orientation = "";

            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else if (width == height)
            {
                orientation = "square";
            }




            Console.WriteLine($"Name: DSC_{name:d4}.jpg");
            Console.WriteLine($"Date Taken: {dateTaken1:d2}/{dateTaken2:d2}/{dateTaken3:d4} {timeHours:d2}:{timeMinutes:d2}");


            if (bytes <= 999)
            {
                Console.WriteLine($"Size: {bytes}B");
            }


            else if (bytes > 999 && bytes < 1000000)
            {
                bytes = bytes/1000; Console.WriteLine($"Size: {bytes}KB");
            }
            else if (bytes >= 1000000)
            {
                bytes = Math.Round(bytes / 1000000, 1); Console.WriteLine($"Size: {bytes}MB");
            }

            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}