using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int i2 = 0; i2 <= number - 1; i2++)
                {
                    for (int i3 = 0; i3 <= number - 1; i3++)
                    {
                        Console.Write("{0}{1}{2}", (char)('a' + i), (char)('a' + i2),(char)('a' + i3));
                        Console.WriteLine();
                    }
                }

            
            }
           
        }
    }
}
