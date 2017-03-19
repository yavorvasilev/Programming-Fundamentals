using System;
using System.Collections.Generic;
using System.Linq;

namespace _3SumAdjacentEqualNumbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < listOfNumbers.Count - 1; i++)
            {
                if (listOfNumbers[i] == listOfNumbers[i + 1])
                {
                    listOfNumbers[i] = listOfNumbers[i] + listOfNumbers[i + 1]; 
                    listOfNumbers.Remove(listOfNumbers[i + 1]);
                    i = -1;
                    
                }
                
            }
            foreach (var item in listOfNumbers)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
