using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split(' ').ToArray();
            string[] lettersChanged = new string[letters.Length];


            for (int i = 0; i < letters.Length - 1; i++)
            {
                lettersChanged[i + 1] = letters[i];
                lettersChanged[0] = letters[letters.Length - 1];
            }
            for (int i = 0; i < lettersChanged.Length; i++)
            {
                Console.Write(lettersChanged[i]+" ");
            }
           

        }
    }
}
