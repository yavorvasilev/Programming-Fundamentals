using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
                if (i == 5 || i == 7)
                {
                    Console.Write(" -> True");
                }
                else if((i / 10 + i % 10 == 5) || (i / 10 + i % 10 == 7) || (i / 10 + i % 10 == 11))
                {
                    Console.Write(" -> True");
                }
                else
                {
                    Console.Write(" -> False");
                }
                Console.WriteLine();
            }
        }
    }
}
