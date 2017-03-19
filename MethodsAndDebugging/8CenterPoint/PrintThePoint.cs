using System;

namespace _8CenterPoint
{
    public class PrintThePoint
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var distance1 = GetDistance(x1, y1);
            var distance2 = GetDistance(x2, y2);

            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        public static double GetDistance(double x, double y)
        {
            if (x == 0)
            {
                return y;
            }
            else if (y == 0)
            {
                return x;
            }
            else
            {
                var distance = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y, 2));
                return distance;
            }

        }
    }
}
