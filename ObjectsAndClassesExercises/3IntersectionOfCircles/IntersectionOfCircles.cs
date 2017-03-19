using System;
using System.Linq;

namespace _3IntersectionOfCircles
{
    public class IntersectionOfCircles
    {
        public static void Main()
        {
            var firstCircleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondCircleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstCenter = new Point(firstCircleInput[0], firstCircleInput[1]);
            var secondCenter = new Point(secondCircleInput[0], secondCircleInput[1]);

            var firstCircle = new Circle(firstCenter, firstCircleInput[2]);
            var secondCircle = new Circle(secondCenter, secondCircleInput[2]);

            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
