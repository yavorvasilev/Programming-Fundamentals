using System;
using System.Linq;

namespace _8CondenceArrayToNumber
{
    public class CondenceArray
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var newCondensed = new int[arr.Length];
            var maxLen = arr.Length;

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else
            { 
                for (int i = 0; i < maxLen - 1; i++)
                {
                    var condensed = GetCondensed(arr);
                    arr = condensed;
                }

                foreach (var num in arr)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
        public static int[] GetCondensed(int[] arr)
        {
            var condensed = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                condensed[i] = arr[i] + arr[i + 1];
            }
            return condensed;
        }
    }
}
