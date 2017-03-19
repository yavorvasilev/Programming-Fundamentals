using System;
using System.Collections.Generic;
using System.Linq;

namespace _4SumReversedNumbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            var listOFNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var rev = 0;
            var dig = 0;

            //var listOfReversed = new List<List<int>>();

            for (int i = 0; i < listOFNumbers.Count; i++)
            {
                while (listOFNumbers[i] > 0)
                {
                    dig = listOFNumbers[i] % 10;
                    rev = rev * 10 + dig;
                    listOFNumbers[i] /=  10;
                }
                
                listOFNumbers[i] = rev;
                //Console.WriteLine(listOFNumbers[i]);
                rev = 0;
            }
            Console.WriteLine(listOFNumbers.Sum());
        }
    }
}
