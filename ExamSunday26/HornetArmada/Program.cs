using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            var legionsByActivity = new Dictionary<string, long>();

            var legionsBySoldiersAndCount = new Dictionary<string, Dictionary<string, long>>();

            var numberOfInputs = long.Parse(Console.ReadLine());

            for (long i = 0; i < numberOfInputs; i++)
            {
                var line = Console.ReadLine()
                    .Split(new char[] { ' ', '=', '-', '>', ':' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                    
                    .ToArray();

                var lastActivity = long.Parse(line[0]);
                var legionName = line[1];
                var soldierType = line[2];
                var soldierCount = long.Parse(line[3]);

                //update activity
                if (!legionsByActivity.ContainsKey(legionName))
                {
                    legionsByActivity[legionName] = lastActivity;
                }
                else
                {
                    if (legionsByActivity[legionName] < lastActivity)
                    {
                        legionsByActivity[legionName] = lastActivity;
                    }
                }

                //update soldier type and count
                if (!legionsBySoldiersAndCount.ContainsKey(legionName))
                {
                    legionsBySoldiersAndCount[legionName] = new Dictionary<string, long>();
                    legionsBySoldiersAndCount[legionName][soldierType] = soldierCount;
                }
                else
                {
                    if (!legionsBySoldiersAndCount[legionName].ContainsKey(soldierType))
                    {
                        legionsBySoldiersAndCount[legionName][soldierType] = soldierCount;
                    }
                    else
                    {
                        legionsBySoldiersAndCount[legionName][soldierType] += soldierCount;
                    }
                }
            }

            var lastLine = Console.ReadLine()
                    .Split(new char[] { '\\' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToArray();

            //Soldier Type
            if (lastLine.Length == 1)
            {
                var soldierType = lastLine.First();
                var listOfLegionName = new List<string>();

                foreach (var legionName in legionsBySoldiersAndCount)
                {
                    foreach (var soldType in legionName.Value)
                    {
                        if (soldierType == soldType.Key)
                        {
                            listOfLegionName.Add(legionName.Key);
                        }
                    }
                }

                foreach (var legionName in legionsByActivity.OrderByDescending(x => x.Value))
                {
                    if (listOfLegionName.Contains(legionName.Key))
                    {
                        Console.WriteLine($"{legionName.Value} : {legionName.Key}");
                    }
                }
            }
            //Activity
            else if(lastLine.Length == 2)
            {
                var activity = long.Parse(lastLine.First());
                var soldierType = lastLine.Last();

                var listOfLegionName = new List<string>();

                foreach (var nameOfLegion in legionsByActivity)
                {
                    if (activity > nameOfLegion.Value)
                    {
                        listOfLegionName.Add(nameOfLegion.Key);
                    }
                }
                var sorted = new Dictionary<string, long>();

                for (int i = 0; i < listOfLegionName.Count; i++)
                {
                    if (legionsBySoldiersAndCount[listOfLegionName[i]].ContainsKey(soldierType))
                    {
                        sorted[listOfLegionName[i]] = legionsBySoldiersAndCount[listOfLegionName[i]][soldierType];
                    }
                }

                foreach (var item in sorted.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }

            }
        }
    }
}
