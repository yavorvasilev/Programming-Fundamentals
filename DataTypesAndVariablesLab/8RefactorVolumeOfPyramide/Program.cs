using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8RefactorVolumeOfPyramide
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, height = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            var area = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", area);

        }
    }
}
