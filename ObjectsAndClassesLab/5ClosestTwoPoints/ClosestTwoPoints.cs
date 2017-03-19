using System;
using System.Linq;
using System.Collections.Generic;

namespace _5ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPointParts = Console.ReadLine().Split().Select(double.Parse).ToArray();

                points.Add(new Point
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1]
                });
            }

            var minDistanceSoFar = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currentDistance = CalculateDistance(firstPoint , secondPoint);

                    if (currentDistance < minDistanceSoFar)
                    {
                        minDistanceSoFar = currentDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistanceSoFar:F3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");
        }


        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}
