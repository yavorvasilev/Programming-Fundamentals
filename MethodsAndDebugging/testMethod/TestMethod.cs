using System;

namespace testMethod
{
    class TestMethod
    {
        static void Main(string[] args)
        {
            var num = 12344321;
            var n = num;
            var rev = 0L;
            var dig = 0L;
            while (num > 0)
            {
                dig = num % 10;
                rev = rev * 10 + dig;
                num = num / 10;
            }
            if (n == rev)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
