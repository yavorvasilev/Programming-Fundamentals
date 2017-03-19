using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberA = double.Parse(Console.ReadLine());
            var numberB = double.Parse(Console.ReadLine());

            //Console.WriteLine(((float) numberA) == ((float) numberB) ? "True" : "False");
            double difference;
            if (Math.Abs(numberA) >= Math.Abs(numberB))
            {
                 difference = Math.Abs(numberA) - Math.Abs(numberB);
            }
            else
            {
                difference = Math.Abs(numberB) - Math.Abs(numberA);
            }
             

            Console.WriteLine(difference < 0.000001  ? "True" : "False");
        }
    }
}
