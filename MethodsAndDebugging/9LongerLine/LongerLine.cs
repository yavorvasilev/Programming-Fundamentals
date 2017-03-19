using System;

namespace _9LongerLine
{
    public class LongerLine
    {
        public static void Main()
        {
            var x1Fir = ReadCoordinates();
            var y1Fir = ReadCoordinates();
            var x2Fir = ReadCoordinates();
            var y2Fir = ReadCoordinates();

            var x1Sec = ReadCoordinates();
            var y1Sec = ReadCoordinates();
            var x2Sec = ReadCoordinates();
            var y2Sec = ReadCoordinates();

            var firstLength = GetLengthLine(x1Fir, y1Fir, x2Fir, y2Fir);
            var secondLength = GetLengthLine(x1Sec, y1Sec, x2Sec, y2Sec);

            if (firstLength > secondLength)
            {

                if (GetDistance(x1Fir, y1Fir) <= GetDistance(x2Fir, y2Fir))
                {
                    Console.WriteLine($"({x1Fir}, {y1Fir})({x2Fir}, {y2Fir})");
                }
                else
                {
                    Console.WriteLine($"({x2Fir}, {y2Fir})({x1Fir}, {y1Fir})");
                }
            }
            else if (secondLength > firstLength)
            {
                if (GetDistance(x1Sec, y1Sec) <= GetDistance(x2Sec,y2Sec))
                {
                    Console.WriteLine($"({x1Sec}, {y1Sec})({x2Sec}, {y2Sec})");
                }
                else
                {
                    Console.WriteLine($"({x2Sec}, {y2Sec})({x1Sec}, {y1Sec})");
                }
            }
            else
            {
                if (GetDistance(x1Fir, y1Fir) <= GetDistance(x2Fir, y2Fir))
                {
                    Console.WriteLine($"({x1Fir}, {y1Fir})({x2Fir}, {y2Fir})");
                }
                else
                {
                    Console.WriteLine($"({x2Fir}, {y2Fir})({x1Fir}, {y1Fir})");
                }
                //Console.WriteLine($"({x1Fir}, {y1Fir})({x2Fir}, {y2Fir})");
            }
            //Console.WriteLine(firstLength);
            //Console.WriteLine(secondLength);
            //Console.WriteLine(GetDistance(x1Sec, y1Sec));
            //Console.WriteLine(GetDistance(x2Sec, y2Sec));

        }

        public static double ReadCoordinates()
        {
            var number = double.Parse(Console.ReadLine());

            return number;
        }

        public static double GetLengthLine(double x1, double y1, double x2, double y2)
        {
            var lenghtLine = 0d;
            var cathetusX = Math.Abs(Math.Abs(x1) + Math.Abs(x2));
            var cathetusY = Math.Abs(Math.Abs(y1) - Math.Abs(y2));

            lenghtLine = Math.Sqrt(Math.Pow(cathetusX, 2) + Math.Pow(cathetusY, 2));

            return lenghtLine;
        }

        public static double GetDistance(double x, double y)
        {
            if (x == 0)
            {
                return Math.Abs(y);
            }
            else if (y == 0)
            {
                return Math.Abs(x);
            }
            else
            {
                var distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                return distance;
            }
        }
    }
}
