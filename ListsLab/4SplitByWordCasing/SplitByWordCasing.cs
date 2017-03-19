using System;
using System.Collections.Generic;
using System.Linq;

namespace _4SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();
            var separators = new char[]
            { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '[', ']', '\'', '\\', '/', ' '};
            var words = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var uperCase = 0;
            var lowerCase = 0;
            var mixedCase = 0;
            var lowerCaseList = new List<string>();
            var uperCaseList = new List<string>();
            var mixedCaseList = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (words[i][j] >= 97 && words[i][j] <= 122)
                    {
                        lowerCase++;
                    }
                    else if(words[i][j] >= 65 && words[i][j] <= 90)
                    {
                        uperCase++;
                    }
                    else
                    {
                        mixedCase++;
                    }
                }
                if (uperCase != 0 && lowerCase == 0 && mixedCase == 0)
                {
                    uperCaseList.Add(words[i]);
                }
                else if (uperCase == 0 && lowerCase != 0 && mixedCase == 0)
                {
                    lowerCaseList.Add(words[i]);
                }
                else
                {
                    mixedCaseList.Add(words[i]);
                }
                lowerCase = 0;
                uperCase = 0;
                mixedCase = 0;
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ",lowerCaseList));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uperCaseList));

        }
    }
}
