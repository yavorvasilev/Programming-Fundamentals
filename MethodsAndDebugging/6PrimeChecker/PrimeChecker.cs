using System;

namespace _6PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            IsPrime(number);
        }

        public static void IsPrime(long number)
        {
            if (number == 0 || number == 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                var status = 0;
                for (long i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("False");
                        status++;
                        break;
                    }
                }
                if (status == 0)
                {
                    Console.WriteLine("True");
                }
               
            }
        }
    }
}

