using System;
using System.Collections.Generic;
using System.Linq;

namespace _4FixEmails
{
    public class FixEmails
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var emailAddresses = new Dictionary<string, string>();

            while ( line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();

                emailAddresses[name] = email;
                line = Console.ReadLine();
            }

            var fixedEmails = emailAddresses
                .Where(a => !a.Value.ToLower().EndsWith("us") && !a.Value.ToLower().EndsWith("uk"))
                .ToDictionary(p => p.Key , p=> p.Value);

            foreach (var item in fixedEmails)
            {
                var name = item.Key;
                var email = item.Value;

                Console.WriteLine($"{name} -> {email}");
            }
                

        }
    }
}
                         