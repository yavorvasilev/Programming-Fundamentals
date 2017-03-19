using System;

namespace _1HelloName
{
    public class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }

        public static void PrintHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
