using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14PracticleFloatingPointNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = 3.141592653589793238m;
            double secondNumber = 1.60217657d;
            decimal thirdNumber = 7.8184261974584555216535342341m;

            Console.WriteLine("{0}\n{1}\n{2}",Math.Round(firstNumber,18), secondNumber, thirdNumber);

        }
    }
}
