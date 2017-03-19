using System;

namespace _4NumbersInReversedOrder
{
    public class ReversedOrder
    {
        public static void Main()
        {
            var number = Console.ReadLine();
            var reversedNumber = Reverse(number);
            Console.WriteLine(reversedNumber);
        }

        public static string Reverse(string number)
        {
            char[] cArray = number.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;

        }
    }
}
