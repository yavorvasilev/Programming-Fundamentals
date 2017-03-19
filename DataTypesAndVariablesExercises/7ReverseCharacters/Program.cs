using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char lastChar = char.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}",lastChar, secondChar, firstChar);


        }
    }
}
