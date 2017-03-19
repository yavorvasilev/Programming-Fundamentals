using System;

namespace _2ReverseAnArrayOfIntegers
{
    public class ReverseArrayIntegers
    {
        public static void Main()
        {
            int numberOfIntegers = int.Parse(Console.ReadLine());

            int[] arrayOfNumbers = new int [numberOfIntegers];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int number = arrayOfNumbers.Length - 1; number >= 0; number--)
            {
                Console.Write($"{arrayOfNumbers[number]} ");
            }
            Console.WriteLine();
        }
    }
}
