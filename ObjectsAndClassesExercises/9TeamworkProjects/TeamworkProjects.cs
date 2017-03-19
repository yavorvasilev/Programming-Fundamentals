using System;
using System.Collections.Generic;
using System.Linq;

namespace _9TeamworkProjects
{
    public class TeamworkProjects
    {
        public static void Main()
        {
            var listOfTeams = new List<Team>();

            var numberOfTeam = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTeam; i++)
            {
                var input = Console.ReadLine().Split('-');

                var nameOfTeam = input[1];
                var nameOfCreator = input[0];
                
                if (listOfTeams.Any(x => x.Name == nameOfTeam))
                {
                    Console.WriteLine($"Team {nameOfTeam} was already created!");
                }

                else if (listOfTeams.Any(x => x.NameOfCreator == nameOfCreator))
                {
                    Console.WriteLine($"{nameOfCreator} cannot create another team!");
                }

                else if (!listOfTeams.Any(x => x.Name == nameOfTeam) && !listOfTeams.Any(x => x.NameOfCreator == nameOfCreator))
                {
                    var team = new Team();
                    team.Name = nameOfTeam;
                    team.NameOfCreator = nameOfCreator;

                    listOfTeams.Add(team);
                    Console.WriteLine($"Team {nameOfTeam} has been created by {nameOfCreator}!");
                }
            }

            var inputAssignment = Console.ReadLine()
                .Split((new char[] { '-', '>' })
                , StringSplitOptions
                .RemoveEmptyEntries);

            while (inputAssignment[0] != "end of assignment")
            {
                var nameOfTeam = inputAssignment[1];
                var member = inputAssignment[0];
                var sameMemberFlag = 0;
                //if (listOfTeams.Any(x => x.Members.Contains(member)))
                //{
                //    Console.WriteLine($"Member {member} cannot join team {nameOfTeam}!");
                //}

                if (listOfTeams.Any(x => x.Name == nameOfTeam) && !listOfTeams.Any(x => x.NameOfCreator == member))
                {
                    foreach (var team in listOfTeams)
                    {
                        if (team.Members != null)
                        {
                            foreach (var userMember in team.Members)
                            {
                                if (userMember == member)
                                {
                                    Console.WriteLine($"Member {member} cannot join team {nameOfTeam}!");
                                    sameMemberFlag = 1;
                                    break;
                                }
                            }
                        }
                    }
                    if (sameMemberFlag == 0)
                    {
                        foreach (var team in listOfTeams)
                        {
                            if (team.Name == nameOfTeam)
                            {
                                if (team.Members == null)
                                {
                                    team.Members = new List<string>();
                                    team.Members.Add(member);
                                }
                                else
                                {
                                    if (team.Members.Contains(member))
                                    {
                                        Console.WriteLine($"Member {member} cannot join team {nameOfTeam}!");
                                        break;
                                    }
                                    else
                                    {
                                        team.Members.Add(member);
                                    }
                                }
                           
                            }
                        }
                    }

                }
                else if (!listOfTeams.Any(x => x.Name == nameOfTeam))
                {
                    Console.WriteLine($"Team {nameOfTeam} does not exist!");
                }
                else if (listOfTeams.Any(x => x.NameOfCreator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {nameOfTeam}!");
                }

                inputAssignment = Console.ReadLine()
                .Split((new char[] { '-', '>' })
                , StringSplitOptions
                .RemoveEmptyEntries);
            }
            var listOfTeamsNull = new List<Team>();
            listOfTeamsNull.AddRange(listOfTeams);
            listOfTeams.RemoveAll(x => x.Members == null);
            listOfTeamsNull.RemoveAll(x => x.Members != null);

            foreach (var team in listOfTeams.OrderByDescending(y=> y.Members.Count).ThenBy(x => x.Name))
            {
                    Console.WriteLine($"{team.Name}");
                    Console.WriteLine($"- {team.NameOfCreator}");
                    foreach (var member in team.Members.OrderBy(x=> x))
                    {
                        Console.WriteLine($"-- {member}");
                    }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in listOfTeamsNull.OrderBy(x => x.Name))
            {
                    Console.WriteLine(team.Name);
            }
        }
    }
}
