using System;
using System.Linq;

namespace _7SumArrays
{
    public class SumArrays
    {
        public static void Main()
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var maxLen = Math.Max(arr1.Length, arr2.Length);
            var minLen = Math.Min(arr1.Length, arr2.Length);

            if (arr1.Length == arr2.Length)
            {
                
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.Write($"{arr1[i] + arr2[i]} ");
                }
                Console.WriteLine();
            }
            else if (arr1.Length > arr2.Length)
            {
                var newArr = GetFullString(arr2, maxLen - minLen, maxLen);
                for (int i = 0; i < maxLen; i++)
                {
                    Console.Write($"{arr1[i] + newArr[i]} ");
                }
                Console.WriteLine();
            }
            else
            {
                var newArr = GetFullString(arr1, maxLen - minLen, maxLen);
                for (int i = 0; i < maxLen; i++)
                {
                    Console.Write($"{newArr[i] + arr2[i]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[] GetFullString(int[] arr, int distinct,int max)
        {

            var newArr = new int[max];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                
            }
            for (int i = 0; i < distinct; i++)
            {
                newArr[ max - distinct + i] = newArr[i];
            }
            return newArr;
        }
    }
}
