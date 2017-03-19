using System;
using System.Linq;

namespace _11EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            var seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sum = 0;
            var maxSum = 0;

            if (seq.Length == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < seq.Length; i++)
                {
                    sum = CheckingSum(seq, i);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
                
                    Console.WriteLine(maxSum);
           
                
            }
        }

        public static int CheckingSum(int[] arr, int index)
        {
            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < index; i++)
            {
                sum1 += arr[i];
            }

            for (int i = index + 1; i < arr.Length; i++)
            {
                sum2 += arr[i];
            }

            if (sum1 == sum2)
            {
                return index;
            }
            else
            {
                index = 0;
                return  index;
            }
            
        }
    }
}
