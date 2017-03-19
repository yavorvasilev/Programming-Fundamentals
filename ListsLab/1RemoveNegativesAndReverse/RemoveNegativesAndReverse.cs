using System;
using System.Linq;
using System.Collections.Generic;

namespace _1RemoveNegativesAndReverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var resultList = new List<int>();

            for (int i = listOfNumbers.Count - 1; i >= 0; i--)
            {
                if (listOfNumbers[i] >= 0)
                {
                    resultList.Add(listOfNumbers[i]);
                }
            }
            if (resultList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", resultList));
            }

            //listOfNumbers.RemoveAll(x=> x < 0);
            //if (listOfNumbers.Count == 0)
            //{
            //    Console.WriteLine("empty");
            //}
            //else
            //{
            //    listOfNumbers.Reverse();
            //    Console.WriteLine(string.Join(" ", listOfNumbers));
            //}

        }
    }
}
