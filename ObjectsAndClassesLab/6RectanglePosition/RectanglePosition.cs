using System;
using System.Linq;

namespace _6RectanglePosition
{
    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangleParts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var secondRectangleParts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstRectangle = new Rectangle
            {
                Left = firstRectangleParts[0],
                Top = firstRectangleParts[1],
                Width = firstRectangleParts[2],
                Height = firstRectangleParts[3]
            };

            var secondRectangle = new Rectangle
            {
                Left = secondRectangleParts[0],
                Top = secondRectangleParts[1],
                Width = secondRectangleParts[2],
                Height = secondRectangleParts[3]
            };

            if (FirstIsInsideSecond(firstRectangle, secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static bool FirstIsInsideSecond(Rectangle first, Rectangle second)
        {
            var leftIsCorrect = first.Left >= second.Left;
            var rightIsCorrect = first.Right <= second.Right;
            var bottomIsCorrect = first.Bottom >= second.Bottom;
            var topIsCorrect = first.Top <= second.Top;

            return leftIsCorrect && rightIsCorrect && bottomIsCorrect && topIsCorrect;
        }
    }
}
