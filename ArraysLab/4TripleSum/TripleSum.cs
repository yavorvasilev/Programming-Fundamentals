using System;
using System.Linq;

namespace _4TripleSum
{
    public class TripleSum
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == CheckSum(arr, arr[i]+ arr[j]))
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {CheckSum(arr, arr[i]+ arr[j])}");
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }

        public static int CheckSum(int[] arr, int sum)
        {
            var number = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (sum == arr[i])
                {
                    number = arr[i];
                }
            }
            return number;
        }
    }
}
