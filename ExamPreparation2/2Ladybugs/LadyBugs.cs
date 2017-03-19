using System;
using System.Linq;

namespace _2Ladybugs
{
    public class LadyBugs
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            var initialIndexes = Console.ReadLine().Split()
                .Select(int.Parse)
                .Where(i => i >= 0 && i < size)
                .ToArray();

            var field = new int[size];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                var indexe = initialIndexes[i];

                field[indexe] = 1;
            }

            var line = Console.ReadLine();

            while (line != "end")
            {
                var command = line.Split().ToArray();

                var startIndex = int.Parse(command[0]);

                var direction = command[1];

                var step = int.Parse(command[2]);

                if (startIndex >= 0 && startIndex < field.Length)
                {
                    if (field[startIndex] == 1)
                    {
                        if (direction == "right")
                        {
                            MoveRight(startIndex, step, field);
                        }
                        else
                        {
                            MoveLeft(startIndex, step, field);
                        }
                    }

                }
                line = Console.ReadLine();
            }

            foreach (var ladyBugs in field)
            {
                Console.Write($"{ladyBugs} ");
            }

            Console.WriteLine();
        }


        public static void MoveRight(int startIndex, int step, int[] field)
        {
                field[startIndex] = 0;
                var ladyBugMove = startIndex + step;

                if (ladyBugMove < field.Length)
                {
                    while (field[ladyBugMove] != 0)
                    {
                        ladyBugMove += step;

                        if (ladyBugMove >= field.Length)
                        {
                            break;
                        }
                    }

                    if (ladyBugMove < field.Length)
                    {
                        field[ladyBugMove] = 1;
                    }
                }
        }
        
        public static void MoveLeft(int startIndex, int step, int[] field)
        {
                field[startIndex] = 0;
                var ladyBugMove = startIndex - step;

                if (ladyBugMove >= 0)
                {
                    while (field[ladyBugMove] != 0)
                    {
                        ladyBugMove -= step;

                        if (ladyBugMove < 0)
                        {
                            break;
                        }
                    }
                    if (ladyBugMove >= 0)
                    {
                        field[ladyBugMove] = 1;
                    }
                }
        }
    }
}
