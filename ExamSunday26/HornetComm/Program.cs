using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {

            var privateMessages = new Dictionary<string,List<string>>();

            var broadcastMessage = new Dictionary<string, List<string>>();

            var line = Console.ReadLine();
            
            var regexMessage = new Regex(@"(^\d+) (?:\<\-\>) ([A-Za-z\d]+)$");
            
            var regexBroadcast = new Regex(@"^([^\d]+) (?:\<\-\>) ([A-Za-z\d]+)$");

            while (line != "Hornet is Green")
            {
                if (regexMessage.IsMatch(line))
                {
                    var firstQuery = regexMessage.Match(line).Groups[1].Value;
                    var secondQuery = regexMessage.Match(line).Groups[2].Value;

                    var reverseFirstMessage = new string(firstQuery.Reverse().ToArray());

                    if (!privateMessages.ContainsKey(reverseFirstMessage))
                    {
                        privateMessages[reverseFirstMessage] = new List<string>();
                    }
                        privateMessages[reverseFirstMessage].Add(secondQuery);
                }

                if (regexBroadcast.IsMatch(line))
                {
                    var firstQuery = regexBroadcast.Match(line).Groups[1].Value;
                    var secondQuery = regexBroadcast.Match(line).Groups[2].Value;

                    var frequency = secondQuery.ToCharArray();
                    
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        var symbols = (int)frequency[i];

                        if (symbols >= 65 && symbols <= 90)
                        {
                            frequency[i] = Char.ToLower(frequency[i]);
                        }
                        if (symbols >= 97 && symbols <= 122)
                        {
                            frequency[i] = Char.ToUpper(frequency[i]);
                        }
                    }
                    var resultCode = new string(frequency);

                    if (!broadcastMessage.ContainsKey(resultCode))
                    {
                        broadcastMessage[resultCode] = new List<string>();
                    }
                    broadcastMessage[resultCode].Add(firstQuery);
                }
                
                line = Console.ReadLine();
            }

            //Print
            Console.WriteLine("Broadcasts:");
            if (broadcastMessage.Count != 0)
            {
                foreach (var message in broadcastMessage)
                {
                    foreach (var item in message.Value)
                    {
                        Console.WriteLine($"{message.Key} -> {item}");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (privateMessages.Count != 0)
            {
                foreach (var message in privateMessages)
                {
                    foreach (var item in message.Value)
                    {
                        Console.WriteLine($"{message.Key} -> {item}");
                    }
                }

            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
