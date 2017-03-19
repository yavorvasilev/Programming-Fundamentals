using System;
using System.Numerics;

namespace _13Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
