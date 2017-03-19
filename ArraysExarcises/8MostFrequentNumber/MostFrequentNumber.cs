using System;
using System.Linq;

namespace _8MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            var seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var currentNumber = 0;
            var repeatedNumber = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                var number = FindRepeatingNumber(seq, seq[i]);
                //Console.WriteLine($"{seq[i]} - {number}" );
                if (number > currentNumber)
                {
                    currentNumber = number;
                    repeatedNumber = seq[i];
                }
            }
            Console.WriteLine(repeatedNumber);

        }

        public static int FindRepeatingNumber(int[] seq, int number)
        {
            var repeat = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                if (number == seq[i])
                {
                    repeat++;
                }
            }

            return repeat;
        }
    }
}