using System;
using System.Linq;

namespace _1ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            
            var output = input.Reverse();

            Console.WriteLine(string.Join("",output));
            
        }
    }
}
