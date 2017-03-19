using System;
using System.Text.RegularExpressions;

namespace _7ReplaceTextInUrlTag
{
    public class ReplaceText
    {
        public static void Main()
        {

            //var text = @"<ul><li><a href=""http://softuni.bg"">SoftUni</a></li></ul>";

            var text = Console.ReadLine();

            while (true)
            {

            }

            var regex = new Regex(@"<a.*href=(""|')(.*)\1>(.*?)<\/a>");

            var result = regex.Replace(text, @"[URL href=""$2""]$3[/URL]");

            Console.WriteLine(result);

            //var matches = regex.Matches(text);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.Groups[0]);
            //    Console.WriteLine(match.Groups[1]);
            //    Console.WriteLine(match.Groups[2]);
            //    Console.WriteLine(match.Groups[3]);
            //}



        }
    }
}
