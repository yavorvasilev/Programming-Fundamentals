using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4StringAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            string overall = firstString + " " + secondString;
            object output = (object)overall;
            Console.WriteLine(output);
        }
    }
}
