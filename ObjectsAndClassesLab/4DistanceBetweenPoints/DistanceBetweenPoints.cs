using System;

namespace _4DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPointParts = Console.ReadLine().Split();

            var firstPoint = new Point
            {
                X = double.Parse(firstPointParts[0]),
                Y = double.Parse(firstPointParts[1])
            };

            var secondPointParts = Console.ReadLine().Split();

            var secondPoint = new Point
            {
                X = double.Parse(secondPointParts[0]),
                Y = double.Parse(secondPointParts[1])
            };

            var result = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{result:F3}");
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
