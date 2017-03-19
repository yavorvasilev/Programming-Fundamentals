using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FastPrimeCheker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isTrue = true;
                for (int a = 2; a <= Math.Sqrt(i); a++)
                {
                    if (Math.Sqrt(i) % a == 0)
                    {
                        isTrue = false;
                    }

                    Console.WriteLine($"{number} -> {isTrue}");
                }
                
            }

        }
    }
}
