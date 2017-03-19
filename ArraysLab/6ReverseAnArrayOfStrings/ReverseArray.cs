using System;
using System.Linq;

namespace _6ReverseAnArrayOfStrings
{
    public class ReverseArray
    {
        public static void Main()
        {

            var arr = Console.ReadLine().Split(' ');
            var reverse = new string[arr.Length];
            for (int i = 0; i < reverse.Length; i++)
            {
                reverse[i] = arr[reverse.Length - 1 -i];
                Console.Write(reverse[i] + " ");
            }

            Console.WriteLine();

        }
    }
}
