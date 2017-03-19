using System;
using System.Linq;


namespace _3FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstRow = new int[inputNumbers.Length / 2];
            var secondRow = new int[inputNumbers.Length / 2];
            var reverseNum = new int[inputNumbers.Length];


            for (int i = 0; i < inputNumbers.Length / 4; i++)
            {
                var firstNum = inputNumbers[0];

                for (int j = 0; j < inputNumbers.Length - 1; j++)
                {
                    inputNumbers[j] = inputNumbers[j + 1];
                }
                inputNumbers[inputNumbers.Length - 1] = firstNum;
            }

            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = inputNumbers[i];
            }

            for (int i = inputNumbers.Length / 2; i < inputNumbers.Length; i++)
            {
                firstRow[i - (inputNumbers.Length - firstRow.Length)] = inputNumbers[i];
            }

            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                var temp = firstRow[i];
                firstRow[i] = firstRow[firstRow.Length - 1 - i];
                firstRow[firstRow.Length - 1 - i] = temp;
            }

            for (int i = 0; i < firstRow.Length; i++)
            {
                Console.Write("{0} ", firstRow[i] + secondRow[i]);
            }
            Console.WriteLine();


        }
    }
}
