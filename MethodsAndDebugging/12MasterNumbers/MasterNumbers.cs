using System;

namespace _12MasterNumbers
{
    public class MasterNumbers
    {
        public static void Main()
        {
            long n = int.Parse(Console.ReadLine());
            bool isPalindrome;
            bool isSumOfDigitsDivisibleBy7;
            bool isNumberContainsEvenDig;
            for (long i = 1; i <= n; i++)
            {
                isPalindrome = IsPalindrome(i);
                isSumOfDigitsDivisibleBy7 = SumOfDigits(i);
                isNumberContainsEvenDig = ContainsEvenDigit(i);

                if (isNumberContainsEvenDig == true && isSumOfDigitsDivisibleBy7 == true && isPalindrome == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(long num)
        {
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
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SumOfDigits(long num)
        {
            var sum = 0L;
            while (num > 0)
            {
                sum += num % 10;

                num = num / 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ContainsEvenDigit(long num)
        {
            while (num > 0)
            {
                long dig = (num % 10) % 2;
                if (dig == 0)
                {
                    //Console.WriteLine("even");
                    return true;
                }
                num = num / 10;
            }

            return false;
        }

    }
}
