using System;
using System.Linq;

namespace _15Substring
{
    public class Substring
    {
        public static void Main()
        {
            var stringInput = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            GetSubstring(stringInput, count);

        }

        public static char[] GetSubstring(string stringInput, int count)
        {
            var substring = new char[count + 1];
            var flag = 0;

            for (int i = 0; i < stringInput.Length; i++)
            {
                if (stringInput[i] == 'p')
                {
                    flag++;
                    for (int j = 0; j < count + 1 && i <= stringInput.Length - 1; j++ ,i++)
                    {
                        substring[j] = stringInput[i];
                    }
                    i--;
                    foreach (var index in substring)
                    {
                        Console.Write(index);
                    }
                    Console.WriteLine();
                    substring = new char[count + 1];
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("no");
            }

            return substring;
        }
    }
}
