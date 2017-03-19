using System;
using System.Numerics;

namespace _14FactorialTrailingZeroes
{
    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var countZero = 0;
            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            //Console.WriteLine(sum);
            while (sum > 0)
            {
                if (sum % 10 == 0)
                {
                    countZero++;
                }
                else
                {
                    break;
                }
                sum = sum / 10;
            }
            Console.WriteLine(countZero);
        
        }
    }
}
