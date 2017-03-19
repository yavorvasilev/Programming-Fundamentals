using System;
using System.Collections.Generic;
using System.Linq;

namespace _6UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            var inputString = Console.ReadLine().Split().ToArray();
            var users = new SortedDictionary<string, Dictionary<string, int>>(); 

            while (inputString[0] != "end")
            {
                var ip = inputString[0];
                ip = ip.Substring(3, ip.Length-3);
                string user = inputString[2];
                user = user.Substring(5, user.Length - 5);

                if (!users.ContainsKey(user))
                {
                    users[user] = new Dictionary<string, int>();
                }
                if (!users[user].ContainsKey(ip))
                {
                    users[user][ip] = 0;
                }
                users[user][ip]++;

                inputString = Console.ReadLine().Split().ToArray();
            }

            foreach (var item in users)
            {
                var user = item.Key;
                Console.WriteLine($"{user}: ");

                foreach (var ip in users[item.Key])
                {
                    if (ip.Key != users[item.Key].Keys.Last())
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }
                    
                }

            }
                //foreach (var user in users)
                //{
                //    Console.WriteLine($"{user.Key}: ");
                //    foreach (var log in user.Value)
                //    {
                //            //var thing = log.Key;
                //            if (log.Key != user.Value.Keys.Last())
                //            {
                //                Console.Write($"{log.Key} => {log.Value}, ");
                        
                //            }
                //            else
                //            {
                //                Console.WriteLine($"{log.Key} => {log.Value}.");
                //            }
                //    }
                //}
        }
    }
}
