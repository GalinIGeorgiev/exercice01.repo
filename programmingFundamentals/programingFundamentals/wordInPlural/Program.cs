using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string Galin = Console.ReadLine();

            if (Galin.EndsWith("y"))
            {
                Galin = Galin.Remove(Galin.Length - 1);
                Galin += "ies";
            }
            else if (Galin.EndsWith("o") ||
                     Galin.EndsWith("s") ||
                     Galin.EndsWith("ch") ||
                     Galin.EndsWith("sh") ||
                     Galin.EndsWith("x") ||
                     Galin.EndsWith("z"))
            {
                Galin = Galin + "es";
            }
            else
            {
                Galin = Galin + "s";
            }
            Console.WriteLine(Galin);

        }
    }
}
