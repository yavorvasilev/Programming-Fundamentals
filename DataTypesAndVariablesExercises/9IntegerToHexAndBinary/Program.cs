using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(number.ToString("X"));
            Console.WriteLine(Convert.ToString(number,2));
            //Console.WriteLine(Convert.ToString(number, 8));
            //Console.WriteLine(Convert.ToString(number, 16));
        }
    }
}
