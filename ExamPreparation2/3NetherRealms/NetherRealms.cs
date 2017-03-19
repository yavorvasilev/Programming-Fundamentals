using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3NetherRealms
{
    public class NetherRealms
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var listOfDemons = new Dictionary<string, Dictionary<int, decimal>>();

            for (int i = 0; i < input.Length; i++)
            {
                var demon = input[i];

                var regexHealth = new Regex(@"[^0-9\+\-\.\*\/]");

                var regexDemage = new Regex(@"[\+\-]?\d+(?:\.?\d+)?");

                var multiplyOrDevide = new Regex(@"[\*\/]");


                var healthPoint = 0;
                var demagePoint = 0M;

                if (regexHealth.IsMatch(demon))
                {
                    var health = regexHealth.Matches(demon);
                    foreach (var letter in health)
                    {
                        var point = char.Parse(letter.ToString());
                        healthPoint += point;
                    }
                }

                if (regexDemage.IsMatch(demon))
                {
                    var demage = regexDemage.Matches(demon);
                    foreach (var number in demage)
                    {
                        var point = decimal.Parse(number.ToString());
                        demagePoint += point;
                    }

                    if (multiplyOrDevide.IsMatch(demon))
                    {
                        var operations = multiplyOrDevide.Matches(demon);
                        foreach (var operation in operations)
                        {
                            var sign = char.Parse(operation.ToString());
                            if (sign == '*')
                            {
                                demagePoint *= 2;
                            }
                            else if (sign == '/')
                            {
                                demagePoint /= 2;
                            }
                        }
                        
                    }

                    
                }
                listOfDemons[demon] = new Dictionary<int, decimal>();
                listOfDemons[demon][healthPoint] = demagePoint;

            }

            foreach (var demon in listOfDemons.OrderBy(x => x.Key))
            {
                Console.Write($"{demon.Key} - ");

                foreach (var kvp in demon.Value)
                {
                    Console.WriteLine($"{kvp.Key} health, {kvp.Value:F2} damage");
                }
            }

            Console.WriteLine();
        }
    }
}
