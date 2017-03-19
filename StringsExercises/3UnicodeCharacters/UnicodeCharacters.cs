using System;
using System.Linq;

namespace _3UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"\\u{(int)input[i]:x4}");
            }
            Console.WriteLine();
        }
    }
}
