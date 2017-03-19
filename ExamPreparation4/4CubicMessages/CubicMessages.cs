using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4CubicMessages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var messageByVerificationCode = new Dictionary<string, List<StringBuilder>>();

            while (line != "Over!")
            {
                var count = int.Parse(Console.ReadLine());

                var regex = new Regex($@"(^\d+)([A-Za-z]{{{count}}})([^A-Za-z]*$)");

                if (regex.IsMatch(line))
                {
                    var matchLine = regex.Match(line);

                    var left = matchLine.Groups[1].Value;

                    var message = matchLine.Groups[2].Value;

                    var right = matchLine.Groups[3].Value;

                    var indexes = string.Concat(left, right).Where(x => char.IsDigit(x)).ToArray();

                    var verificationCode = new StringBuilder();
                    for (int i = 0; i < indexes.Length; i++)
                    {
                        var index = int.Parse((indexes[i]).ToString());
                        if (index < 0 || index >= message.Length)
                        {
                            verificationCode.Append(' ');
                        }
                        else
                        {
                            verificationCode.Append(message[index]);
                        }
                    }

                    //var flag = true;
                    //for (int i = 0; i < verificationCode.Length; i++)
                    //{
                    //    var ch = ' ';
                    //    if (verificationCode[i] != ch)
                    //    {
                    //        flag = false;
                    //        break;
                    //    }
                    //}
                    //if (!flag)
                    //{
                        if (!messageByVerificationCode.ContainsKey(message))
                        {
                            messageByVerificationCode[message] = new List<StringBuilder>();
                            messageByVerificationCode[message].Add(verificationCode);
                        }
                        else
                        {
                            messageByVerificationCode[message].Add(verificationCode);
                        }
                    //}
                    //else
                    //{
                    //    verificationCode = verificationCode.Clear();
                    //    verificationCode.Append(' ');

                    //    if (!messageByVerificationCode.ContainsKey(message))
                    //    {
                    //        messageByVerificationCode[message] = new List<StringBuilder>();
                    //        messageByVerificationCode[message].Add(verificationCode);
                    //    }
                    //    else
                    //    {
                    //        messageByVerificationCode[message].Add(verificationCode);
                    //    }
                    //} 
                }
                line = Console.ReadLine();
            }

            foreach (var message in messageByVerificationCode)
            {
                foreach (var item in message.Value.Distinct())
                {
                    Console.Write($"{message.Key} == {item}");
                    Console.WriteLine();
                }
            }
        }
    }
}
