using System;
using System.Linq;


namespace _5CompareCharArrays
{
    public class CompareCharArrays
    {
        public static void Main()
        {

            var arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            var max = Math.Max(arr1.Length,arr2.Length);
            var min = Math.Min(arr1.Length,arr2.Length);


            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }
            else if (arr1.Length < arr2.Length)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < min; i++)
                {
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));
                        break;
                    }
                    if (arr2[i] > arr1[i])
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                        break;
                    }
                    if (arr1[i] == arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                        break;
                    }
                }
            }

        }
    }
}
