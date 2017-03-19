using System;
using System.Linq;

namespace _10PairsByDifference
{
    public class PairsByDifference
    {
        public static void Main()
        {
            var seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var startIndex = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                count += CheckingDifferences(seq, seq[i], n, startIndex);
                startIndex++;
            }
            Console.WriteLine(count);
        }

        public static int CheckingDifferences(int[] seq, int number, int difference, int startIndex)
        {
            var count = 0;
            for (int i = startIndex; i < seq.Length; i++)
            {
                if (Math.Abs(number - seq[i]) == difference)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
