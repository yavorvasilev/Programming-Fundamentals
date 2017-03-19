using System;
using System.Linq;
using System.Collections.Generic;

namespace _2AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split('|').ToArray();

            var resultList = new List<string>();

            for (int i = inputList.Length - 1; i >= 0; i--)
            {
                var text = inputList[i].Split(' ');

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] != "")
                    {
                        resultList.Add(text[j]);
                    }
                }
           
            }
            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
