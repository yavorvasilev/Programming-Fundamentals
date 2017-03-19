using System;
using System.Collections.Generic;
using System.Linq;

namespace _2OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split();
            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 0;
                }
                wordCount[word]++;
            }
            var listOfWords = new List<string>();
            foreach (var word in wordCount)
            {
                if (word.Value % 2 != 0)
                {
                    listOfWords.Add(word.Key);
                }
            }
            Console.Write(string.Join(", ", listOfWords));
            Console.WriteLine();
        }
    }
}
