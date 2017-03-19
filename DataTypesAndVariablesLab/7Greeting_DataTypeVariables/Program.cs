using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Greeting_DataTypeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            
        
            Console.WriteLine($"Hello, {firstName} {lastName}.\nYou are {age} years old.");


        }
    }
}
