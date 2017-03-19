using System;
using System.Collections.Generic;
using System.Linq;

namespace _5BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            var listOFNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombNumberAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //1 4 4 2 8 9 1
            //9 3
            for (int i = 0; i < listOFNumbers.Count; i++)
            {
                if (listOFNumbers[i] == bombNumberAndPower[0])
                {
                    if (listOFNumbers.Count - 1 >= i + bombNumberAndPower[1] && i - bombNumberAndPower[1] >= 0)
                    {
                        for (int j = i - bombNumberAndPower[1]; j <= i + bombNumberAndPower[1]; j++)
                        {
                            listOFNumbers[j] = 0;
                        }
                    }
                    else if (listOFNumbers.Count - 1 < i + bombNumberAndPower[1])
                    {
                        for (int j = i - bombNumberAndPower[1]; j < listOFNumbers.Count; j++)
                        {
                            listOFNumbers[j] = 0;
                        }
                    }
                    else if (i - bombNumberAndPower[1] < 0)
                    {
                        for (int j = 0; j <= i + bombNumberAndPower[1]; j++)
                        {
                            listOFNumbers[j] = 0;
                        }
                    }
                }
            }
            //Console.WriteLine(string.Join(" ", listOFNumbers));
            Console.WriteLine(listOFNumbers.Sum());
        }
    }
}
