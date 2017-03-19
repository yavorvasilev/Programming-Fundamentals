using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(inputNumber, 16));
        }
    }
}
