using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F12}",Math.PI * radius * radius);
        }
    }
}
