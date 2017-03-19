using System;
using System.Text.RegularExpressions;

namespace _1ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine();

                var regex = new Regex(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)");

                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    var matchString = match.ToString();

                    if (!(matchString.StartsWith("-") || matchString.StartsWith(".") || matchString.StartsWith("_")))
                    {
                        Console.Write(match);
                        Console.WriteLine();
                    }
                    
                }     
        }
    }
}
