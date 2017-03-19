using System;
using System.Linq;

namespace _9IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            //var letters = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            var letters = Console.ReadLine();

            for (int i = 0; i < letters.Length; i++)
            {
                int index = letters[i];
                Console.WriteLine($"{letters[i]} -> {index-97}");
            }



        }
    }
}
