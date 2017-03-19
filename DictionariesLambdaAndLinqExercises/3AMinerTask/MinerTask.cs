using System;
using System.Collections.Generic;
using System.Linq;

namespace _3AMinerTask
{
    public class MinerTask
    {
        public static void Main(string[] args)
        {
            var minerTasks = new Dictionary<string, int>();
            string resources;
            int quantity;

            resources = Console.ReadLine();

            while (!(resources == "stop"))
            {
                quantity = int.Parse(Console.ReadLine());
                if (minerTasks.ContainsKey(resources))
                {
                   minerTasks[resources] += quantity;
                }
                else
                {
                    minerTasks[resources] = quantity;
                }
                resources = Console.ReadLine();
                
            }
            foreach (var item in minerTasks)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

        }
    }
}
