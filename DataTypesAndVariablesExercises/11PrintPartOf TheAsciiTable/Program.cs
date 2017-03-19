using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11PrintPartOf_TheAsciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var charIndexStart = int.Parse(Console.ReadLine());
            var charIndexFinish = int.Parse(Console.ReadLine());

            for (int charIndex = charIndexStart; charIndex <= charIndexFinish; charIndex++)
            {
                Console.Write("{0} ", (char)charIndex);
            }
            Console.WriteLine();
        }
    }
}
