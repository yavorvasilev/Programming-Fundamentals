using System;
using System.Linq;

namespace _5ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {

            var text = Console.ReadLine().ToLower()
                .Split(".,:;()[]'\\/!?\" "
                .ToCharArray(), StringSplitOptions
                .RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToList();

            
                Console.Write(string.Join(", ", text));
                Console.WriteLine();
            
        }
    }
}
