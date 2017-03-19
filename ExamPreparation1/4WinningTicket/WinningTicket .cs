using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4WinningTicket
{
    public class WinningTicket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(new char[] { ' ', ',' }
            , StringSplitOptions.RemoveEmptyEntries).ToArray();

            var regex = new Regex(@"([\$]{6,10})|([\#]{6,10})|([\@]{6,10})|([\^]{6,10})");


            foreach (var ticket in tickets)
            {
                var left = new string(ticket.Take(10).ToArray());
                var right = new string(ticket.Skip(10).ToArray());

                var symbolsLeft = regex.Matches(left);
                var symbolsRight = regex.Matches(right);

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (symbolsLeft.Count == 1 && symbolsRight.Count == 1)
                {
                    //var text = ticket.Substring(0, 10);

                    var countLeft = 0;
                    var countRight = 0;
                    string symbols = default(string);

                    foreach (Match symbol in symbolsLeft)
                    {
                        countLeft = symbol.Length;
                        symbols = (string)(symbol.ToString());
                    }

                    foreach (Match symbol in symbolsRight)
                    {
                        countRight = symbol.Length;
                        symbols = (string)(symbol.ToString());
                    }

                    var min = Math.Min(countLeft, countRight);
                    var alphabet = symbols.First();

                    if (min == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {min}{symbols[0]} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {min}{symbols[0]}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }


        }
    }
}
