using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var command = line.Split();
                switch (command[0])
                {
                    case "exchange":
                        var index = int.Parse(command[1]);
                        arr = ExchangeArray(index, arr);
                        break;
                    case "max":
                    case "min":
                        var maxOrMin = command[0];
                        var evenOrOdd = command[1];
                        GetMaxOrMinEvenOrOdd(maxOrMin, evenOrOdd, arr);
                        break;
                    case "first":
                    case "last":
                        var firstOrLast = command[0];
                        var count = int.Parse(command[1]);
                        evenOrOdd = command[2];
                        if (count < 0 || count > arr.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            GetFirstOrLastEvenOrOddNumbers(firstOrLast, evenOrOdd, count, arr);
                        }
                        break;
                }

                line = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static void GetFirstOrLastEvenOrOddNumbers(string firstOrLast, string evenOrOdd, int count, int[] arr)
        {
            //Even
            if (evenOrOdd == "even")
            {
                var evenNumbers = arr.Where(n => n % 2 == 0).ToArray();
                //Get firstOrLast even
                if (evenNumbers.Length != 0)
                {
                    if (firstOrLast == "first")
                    {
                        if (count > evenNumbers.Length)
                        {
                            Console.WriteLine($"[{string.Join(", ", evenNumbers)}]");
                        }
                        else
                        {
                            var result = evenNumbers.Take(count).ToArray();
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                    }
                    else if (firstOrLast == "last")
                    {
                        if (count > evenNumbers.Length)
                        {
                            Console.WriteLine($"[{string.Join(", ", evenNumbers)}]");
                        }
                        else
                        {
                            var result = evenNumbers.Skip(evenNumbers.Length - count).ToArray();
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }

            //Odd
            if (evenOrOdd == "odd")
            {
                var evenNumbers = arr.Where(n => n % 2 == 1).ToArray();
                //Get firstOrLast even
                if (evenNumbers.Length != 0)
                {
                    if (firstOrLast == "first")
                    {
                        if (count > evenNumbers.Length)
                        {
                            Console.WriteLine($"[{string.Join(", ", evenNumbers)}]");
                        }
                        else
                        {
                            var result = evenNumbers.Take(count).ToArray();
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                    }
                    else if (firstOrLast == "last")
                    {
                        if (count  > evenNumbers.Length)
                        {
                            Console.WriteLine($"[{string.Join(", ", evenNumbers)}]");
                        }
                        else
                        {
                            var result = evenNumbers.Skip(evenNumbers.Length - count).ToArray();
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        private static void GetMaxOrMinEvenOrOdd(string maxOrMin, string evenOrOdd, int[] arr)
        {
            if (evenOrOdd == "even")
            {
                var result = arr.Where(n => n % 2 == 0).OrderByDescending(x => x).ToArray();
                //Get MaxOrMin even
                if (result.Length != 0)
                {
                    var evenNumber = 0;

                    if (maxOrMin == "max")
                    {
                        evenNumber = result.First();
                    }
                    else
                    {
                        evenNumber = result.Last();
                    }

                    Console.WriteLine(Array.LastIndexOf(arr, evenNumber));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
               
            }
            if (evenOrOdd == "odd")
            {
                var result = arr.Where(n => n % 2 == 1).OrderByDescending(x => x).ToArray();

                //Get MaxOrMin odd
                if (result.Length != 0)
                {
                    var oddNumber = 0;

                    if (maxOrMin == "max")
                    {
                        oddNumber = result.First();
                    }
                    else
                    {
                        oddNumber = result.Last();
                    }

                    Console.WriteLine(Array.LastIndexOf(arr, oddNumber));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
               
            }
        }

        private static int[] ExchangeArray(int index, int[] arr)
        {

            if (index < 0 || index + 1 > arr.Length)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                var leftArr = arr.Take(index + 1);
                var rightArr = arr.Skip(index + 1);

                arr = rightArr.Concat(leftArr).ToArray();
            }
            return arr;
        }
    }
}
