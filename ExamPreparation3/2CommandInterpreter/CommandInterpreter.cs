using System;
using System.Linq;

namespace _2CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new char[] { ' ' }, 
                StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var command = line.Split(new char[] { ' ' },
                StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();

                switch (command[0])
                {
                    case "reverse":
                        var start = command[2];
                        var count = command[4];
                        ReverseArray(start, count, arr);
                        break;

                    case "sort":
                        var startSort = command[2];
                        var countSort = command[4];
                        SortArray(startSort, countSort, arr);
                        break;

                    case "rollLeft":
                        var countRollLeft = command[1];
                        RollLeftArray(countRollLeft, arr);
                        break;

                    case "rollRight":
                        var countRollRight = command[1];
                        RollRightArray(countRollRight, arr);
                        break;
                        
                }


                line = Console.ReadLine();
            }

            foreach (var item in arr)
            {
                Console.Write($"");
            }
            Console.WriteLine("[{0}]",string.Join(", ", arr));


        }

        private static void RollLeftArray(string count, string[] arr)
        {
            var countRoll = int.Parse(count);

            if (countRoll < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else if((countRoll%arr.Length) != 0)
            {
                for (int i = 0; i < countRoll % arr.Length; i++)
                {
                    var firstNumber = arr[0];

                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[arr.Length - 1] = firstNumber;
                }
            }
        }

        private static void RollRightArray(string count, string[] arr)
        {
            var countRoll = int.Parse(count);

            if (countRoll < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else if(countRoll%arr.Length != 0)
            {
                for (int i = 0; i < countRoll % arr.Length; i++)
                {
                    var lastNumber = arr[arr.Length - 1];
                    for (int j = arr.Length-1; j > 0; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[0] = lastNumber;
                }
            }
            
        }

        private static void SortArray(string start, string count, string[] arr)
        {
            var startIndex = int.Parse(start);
            var countIndex = int.Parse(count);

            if (startIndex < 0 ||
                startIndex >= arr.Length ||
                startIndex + countIndex - 1 >= arr.Length ||
                countIndex < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                var sortedArr = arr
                    .Skip(startIndex)
                    .Take(countIndex)
                    .OrderBy(x => x)
                    .ToArray();
                var start1 = startIndex;
                for (int i = 0; i < sortedArr.Length; i++, start1++)
                {
                    arr[start1] = sortedArr[i];
                }
                    
            }
        }

        private static void ReverseArray(string start, string count, string[] arr)
        {
            var startIndex = int.Parse(start);
            var countIndex = int.Parse(count);

            if (startIndex < 0 || 
                startIndex >= arr.Length ||
                startIndex + countIndex - 1 >= arr.Length ||
                countIndex < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                var start1 = startIndex;

                for (int i = 0; i < countIndex / 2; i++ , start1++)
                {
                    var temp = arr[start1];
                    arr[start1] = arr[startIndex + countIndex - 1 - i];
                    arr[startIndex + countIndex - 1 - i] = temp;
                }
            }
        }
    }
}
