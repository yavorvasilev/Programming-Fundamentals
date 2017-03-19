using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var allString = new StringBuilder();

            var finalString = new StringBuilder();

            var regex = new Regex(@"([^\d]{1,20})([\d]{0,20})");

            var matchInput = regex.Matches(input);

            foreach (Match match in matchInput)
            {
                var inputString = (match.Groups[1].ToString()).ToUpper();
                var number = int.Parse(match.Groups[2].ToString());
                allString.Append(inputString);
                for (int i = 0; i < number; i++)
                {
                    finalString.Append(inputString);
                }
            }
            var count = new List<char>();

            var stringWithoutSpace = allString.ToString().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToString();
            

            for (int i = 0; i < allString.Length; i++)
            {
                //if (allString[i] != ' ')
                //{
                    count.Add(allString[i]);
               // }
                
            }
            var uniqeChar = count.Distinct(); // first variant that calc 'C' char

            var ubiqeChar2 = finalString.ToString().Distinct(); // second variant that not calc 'C' char

            Console.WriteLine($"Unique symbols used: {uniqeChar.Count()}");


            Console.WriteLine(finalString);

        }
    }
}
