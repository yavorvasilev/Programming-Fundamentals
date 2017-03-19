using System;
using System.Collections.Generic;
using System.Linq;

namespace _8LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            var userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputText = Console.ReadLine().Split().ToArray();

                var ipAddress = inputText[0];
                var duration = int.Parse(inputText[2]);
                var user = inputText[1];

                if (!userLogs.ContainsKey(user))
                {
                    userLogs[user] = new SortedDictionary<string, int>();
                }

                if (!userLogs[user].ContainsKey(ipAddress))
                {
                    userLogs[user][ipAddress] = duration;
                }
                else
                {
                    userLogs[user][ipAddress] += duration;
                }
            }

            foreach (var user in userLogs)
            {
                Console.Write($"{user.Key}: {user.Value.Sum(x => x.Value)} ");
                Console.WriteLine("[{0}]",string.Join(", ", user.Value.Select(x => x.Key)));
            }
        }
    }
}
