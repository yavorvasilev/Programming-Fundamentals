using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = 5;
            var secondNumber = 10;
            var a = secondNumber;
            var b = firstNumber;
            Console.WriteLine("Before: \na = {0}\nb = {1}", firstNumber, secondNumber);
            //Console.WriteLine("a = {0}", firstNumber);
            //Console.WriteLine("b = {0}", secondNumber);
            Console.WriteLine("After: \na = {0}\nb = {1}", a, b);
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);
        }
    }
}
