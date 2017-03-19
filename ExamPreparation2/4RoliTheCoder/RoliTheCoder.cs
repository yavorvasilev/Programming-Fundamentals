using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            var dictionaryOfEvents = new Dictionary<long, string>();

            var dictionaryOfParticipants = new Dictionary<string, List<string>>();

            var line = Console.ReadLine();

            while (line != "Time for Code")
            {
                var inputRequest = line.Split(new char[]{ ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();

                if (inputRequest[0].All(char.IsDigit))
                {
                    var eventId = long.Parse(inputRequest[0]);

                    var eventName = inputRequest[1];

                    if (eventName.First() == '#')
                    {
                        var listOfParticipants = new List<string>();

                        //creat list of participant
                        for (int p = 2; p < inputRequest.Count; p++)
                        {
                            if (inputRequest[p].First() == '@')
                            {
                                listOfParticipants.Add(inputRequest[p]);
                            }
                        }

                        var name = new string(eventName.Skip(1).ToArray());

                        if (!dictionaryOfEvents.ContainsKey(eventId))
                        {
                            dictionaryOfEvents[eventId] = eventName;
                            dictionaryOfParticipants[name] = new List<string>();
                            dictionaryOfParticipants[name].AddRange(listOfParticipants.Distinct());

                        }
                        else if (dictionaryOfEvents.ContainsValue(eventName))
                        {
                            foreach (var participant in listOfParticipants)
                            {
                                if (!dictionaryOfParticipants[name].Contains(participant))
                                {
                                    dictionaryOfParticipants[name].Add(participant);
                                }
                            }
                        }
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var events in dictionaryOfParticipants.Distinct().OrderByDescending(x => x.Value.Count).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{events.Key} - {events.Value.Count}");

                foreach (var participant in events.Value.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
            Console.WriteLine();
        }
    }
}
