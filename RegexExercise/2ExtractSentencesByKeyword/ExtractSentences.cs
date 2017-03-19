using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2ExtractSentencesByKeyword
{
    public class ExtractSentences
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();
            //var keyWord = Console.ReadLine();
            var sentences = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var regex = new Regex("\\b" + keyWord + "\\b");

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
