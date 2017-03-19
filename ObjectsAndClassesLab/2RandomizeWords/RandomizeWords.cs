using System;
using System.Collections.Generic;

namespace _2RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();

            var random = new Random();

            //var result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomIndex = random.Next(0, words.Length);

                var tempWords = words[randomIndex];
                words[i] = tempWords;
                words[randomIndex] = currentWord;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
