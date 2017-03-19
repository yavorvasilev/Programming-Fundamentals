using System;
using System.Collections.Generic;

namespace _7PrimesInGivenRange
{
    public class PrimesInGivenRange
    {
        public static void Main()
        {
            //for (;; )
            //{

        
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

      
            var list = FindPrimesInRange(startNum, endNum);


            for (int i = 0; i <= list.Count; i++)
            {
                Console.Write("{0}", list[i]);
                if (i == list.Count - 1)
                {
                    break;
                }
                Console.Write(", ");

            }
            //foreach (int prime in list)
            //{

            //    Console.Write($"{prime} ");

            //}
            // Console.WriteLine();

            //}

        }

        public static List<int>FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeNumbers = new List<int>();
            if (startNum == 0 || startNum == 1)
            {
                startNum = 2;
            }
            //List<int> primeNumbers;
            //if (number == 0 || number == 1)
            //{
            //    Console.WriteLine("False");
            //}
            //else
            //{

            for (int number = startNum; number <= endNum; number++)
            {
                var status = 0;
                for (int a = 2; a <= Math.Sqrt(number); a++)
                {
                    if (number % a == 0)
                    {
                        status++;
                        break;
                    }
                }
                if (status == 0)
                {
                    ///Console.WriteLine("True");
                    primeNumbers.Add(number);
                }
            }

 
            return primeNumbers;
        }
    }
}
