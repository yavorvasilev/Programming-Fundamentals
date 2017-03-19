using System;

namespace _3LastKNumbersSums
{
    public class NumbersSums
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var k = long.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;
            long sum = 0;
            //var sum2 = 0;

            for (long number = 1; number < n; number++)
            {
                if (number > k)
                {
                    for (long i = number - k; i < number - 1; i++)
                    {
                        sum += array[i];
                    }
                    array[number] = sum;
                }
                else
                {
                    sum += array[number - 1];
                    array[number] = sum;
                }
            }
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
