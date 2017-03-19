using System;

namespace StringDemos
{
    public class StringDemos
    {
        public static void Main()
        {
            var str1 = "pesho";

            var str2 = "Pesho";

            var result = string.Compare(str1, str2, true);

            Console.WriteLine(result);
        }
    }
}
