using System;
using System.Linq;

namespace _1LargestCommonEnd
{
    public class LargestCommonEnd
    {
        public static void Main()
        {
            
            string[] firstString = Console.ReadLine().Split(' ').ToArray();
            string[] secondString = Console.ReadLine().Split(' ').ToArray();

            var maxValue = Math.Max(firstString.Length, secondString.Length);
            var minValue = Math.Min(firstString.Length, secondString.Length);

            var longString = new string[Math.Max(firstString.Length, secondString.Length)];
            var shortString = new string[Math.Min(firstString.Length, secondString.Length)];
            ////string[] newString = new string[firstString.Length];
            if (firstString.Length >= secondString.Length)
            {
                longString = firstString;
                shortString = secondString;
            }
            else
            {
                longString = secondString;
                shortString = firstString;
            }

            long sum = 0;
            long secondSum = 0;

            for (int index = 0; index < minValue; index++)
            {
                    if (longString[index] == shortString[index])
                    {
                        sum++;
                    }
            }
            for (int index = minValue - 1 ; index >= 0; index--)
            {

                if (shortString[index] == longString[index + (maxValue - minValue)])
                {
                    secondSum++;
                }

            }

            if (sum >= secondSum && sum != 0)
            {
                Console.WriteLine(sum);
            }
            else if(secondSum > sum)
            {
                Console.WriteLine(secondSum);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
