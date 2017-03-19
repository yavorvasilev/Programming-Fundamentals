using System;
using System.Linq;

namespace _9ExtractMiddle
{
    public class ExtractMiddle
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var len = nums.Length;
            if (len == 1)
            {
                Console.Write("{ ");
                Console.Write("{0}", nums[0]);
                Console.WriteLine(" }");
            }
            else if (len % 2 != 0)
            {
                Console.Write("{ ");
                Console.Write("{0}, {1}, {2}", nums[len / 2 - 1], nums[len / 2], nums[len / 2 + 1]);
                Console.WriteLine(" }");
            }
            else
            {
                Console.Write("{ ");
                Console.Write("{0} {1} ", nums[len / 2 - 1], nums[len / 2]);
                Console.WriteLine(" }");
            }
            
        }
    }
}
