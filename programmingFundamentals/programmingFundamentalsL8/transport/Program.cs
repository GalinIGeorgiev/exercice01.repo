using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());

            double numOfCourses = Math.Ceiling(numberOfPeople / 24);
            Console.WriteLine(numOfCourses);

        }
    }
}
