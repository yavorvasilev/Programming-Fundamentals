using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3FootballStandings
{
    class FootballStandings
    {
        static void Main(string[] args)
        {
            var teamsByPoints = new Dictionary<string, long>();

            var teamsByGoals = new Dictionary<string, long>();

            var key = Console.ReadLine();

            key = Regex.Escape(key);

            var regexTeamName = new Regex($@"{key}(.*?){key}");
            var regexGoals = new Regex(@"(\d+):(\d+)");

            var line = Console.ReadLine();

            while (line != "final")
            {
                if (regexTeamName.IsMatch(line) && regexGoals.IsMatch(line))
                {
                    var matchTeams = regexTeamName.Matches(line);
                    var matchGolas = regexGoals.Match(line);
                    var listOfNames = new List<string>();

                    foreach (Match match in matchTeams)
                    {
                        var matchName = match.Groups[1].ToString();
                        var name = new string(matchName.Reverse().ToArray()).ToUpper();

                        if (!teamsByPoints.ContainsKey(name) && !teamsByGoals.ContainsKey(name))
                        {
                            teamsByGoals[name] = 0;
                            teamsByPoints[name] = 0;
                        }

                        listOfNames.Add(name);
                    }
                    var firstName = listOfNames.First();

                    var secondName = listOfNames.Last();

                    var firstTeamGoal = int.Parse(matchGolas.Groups[1].ToString());

                    var secondTeamGoal = int.Parse(matchGolas.Groups[2].ToString());

                    if (firstTeamGoal == secondTeamGoal)
                    {
                        teamsByGoals[firstName] += firstTeamGoal;
                        teamsByGoals[secondName] += secondTeamGoal;
                        teamsByPoints[firstName] += 1;
                        teamsByPoints[secondName] += 1;
                    }
                    if (firstTeamGoal > secondTeamGoal)
                    {
                        teamsByGoals[firstName] += firstTeamGoal;
                        teamsByGoals[secondName] += secondTeamGoal;
                        teamsByPoints[firstName] += 3;
                    }
                    if (secondTeamGoal > firstTeamGoal)
                    {
                        teamsByGoals[firstName] += firstTeamGoal;
                        teamsByGoals[secondName] += secondTeamGoal;
                        teamsByPoints[secondName] += 3;
                    }
                }

                line = Console.ReadLine();
            }
            var count = 1;
            Console.WriteLine("League standings:");
            foreach (var team in teamsByPoints.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value}");
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teamsByGoals.OrderByDescending(x => x.Value).ThenBy(n => n.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }
    }
}
