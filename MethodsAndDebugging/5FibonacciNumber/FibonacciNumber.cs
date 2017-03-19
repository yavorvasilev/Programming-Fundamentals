using System;

namespace _5FibonacciNumber
{
    public class FibonacciNumber
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(number));
        }
        public static int Fib(int number)
        {
            int f0 = 1;
            int f1 = 1;

            for (int i = 0; i < number; i++)
            {
                int temp = f0;
                f0 = f1;
                f1 = temp + f1;
            }
            return f0;
        }
    }
}
