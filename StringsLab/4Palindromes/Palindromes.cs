using System;
using System.Linq;
using System.Collections.Generic;

namespace _4Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { '.', '!', '?', ',',' ' }, StringSplitOptions.RemoveEmptyEntries);

            var listOfPalindromes = new List<string>();

            foreach (var word in text)
            {
                var palindromes = word.ToCharArray();
                var revereseWord = palindromes.Reverse().ToArray();

                var a = palindromes.SequenceEqual(revereseWord);

                if (palindromes.SequenceEqual(revereseWord))
                {
                    listOfPalindromes.Add(word);
                }
               
            }

            Console.WriteLine(string.Join(", ",listOfPalindromes.Distinct().OrderBy(x => x)));

        }
    }
}
