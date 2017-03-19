using System;

namespace _11GeometryCalculator
{
    public class GeometryCalculator
    {
        public static void Main()
        {
            var figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                GetAreaOFTriangle();
            }
            if (figureType == "square")
            {
                GetAreaOFSuare();
            }
            if (figureType == "rectangle")
            {
                GetAreaOFRectangle();
            }
            if (figureType == "circle")
            {
                GetAreaOFCircle();
            }
        }

        public static void GetAreaOFTriangle()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = (side * height) / 2;

            Console.WriteLine("{0:F2}", area);
        }
        public static void GetAreaOFSuare()
        {
            var side = double.Parse(Console.ReadLine());

            var area = side * side;

            Console.WriteLine("{0:F2}", area);
        }
        public static void GetAreaOFRectangle()
        {
            var wildth = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = wildth * height;

            Console.WriteLine("{0:F2}", area);
        }
        public static void GetAreaOFCircle()
        {
            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * radius * radius;

            Console.WriteLine("{0:F2}", area);
        }

    }
}
