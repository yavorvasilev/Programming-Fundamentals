using System;
using System.Linq;

namespace _2RotateAndSum
{
    public class RotateAndSum
    {
        public static void Main()
        {
            var arrayNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //for (int i = 0; i < arrayNumbers.Length; i++)
            //{
            //    Console.WriteLine(arrayNumbers[i]);
            //}

            int n = int.Parse(Console.ReadLine());

            var sum = new int[arrayNumbers.Length];

            for (int i = 0; i < n; i++)
            {
                var lastNumber = arrayNumbers[arrayNumbers.Length - 1];

                for (int j = arrayNumbers.Length -1 ; j > 0; j--)
                {
                    arrayNumbers[j] = arrayNumbers[j - 1]; 
                }
                arrayNumbers[0] = lastNumber;
                //Console.WriteLine(string.Join(" ", arrayNumbers));

                for (int j = 0; j < arrayNumbers.Length; j++)
                {
                    sum[j] += arrayNumbers[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
            
        }
    }
}
