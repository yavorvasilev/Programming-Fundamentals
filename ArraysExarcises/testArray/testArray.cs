
using System;
using System.Collections.Generic;
using System.Linq;
 
namespace _11.Equal_Sums
{
    class Program
    {
        static void Main()
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr1.Length  / 2; i++)
            {
                var temp = arr1[i];
                arr1[i] = arr1[arr1.Length - 1 - i];
                arr1[arr1.Length - 1 - i] = temp;
            }
            foreach (var item in arr1)
            {
                Console.Write("{0} ", item);
            }

        }
    }
}
