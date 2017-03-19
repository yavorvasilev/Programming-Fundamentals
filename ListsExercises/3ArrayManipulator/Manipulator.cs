using System;
using System.Collections.Generic;
using System.Linq;

namespace _3ArrayManipulator
{
    public class Manipulator
    {
        public static void Main()
        { 
            var listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var command = Console.ReadLine().Split().ToList();

            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    listOfNumbers = AddNumber(int.Parse(command[1]), int.Parse(command[2]), listOfNumbers);
                }
                if (command[0] == "addMany")
                {
                    var listOfNumbersForAdding = command.Skip(2).Select(int.Parse).ToList();
                    listOfNumbers = AddManyNumbers(int.Parse(command[1]), listOfNumbersForAdding, listOfNumbers);
                }
                if (command[0] == "contains")
                {
                    ContainsElement(int.Parse(command[1]), listOfNumbers);
                }
                if (command[0] == "remove")
                {
                    listOfNumbers = RemoveElement(int.Parse(command[1]), listOfNumbers);
                }
                if (command[0] == "shift")
                {
                    listOfNumbers = ShiftingElements(int.Parse(command[1]), listOfNumbers);
                }
                if (command[0] == "sumPairs")
                {
                    listOfNumbers = SumOfPairsNumbers(listOfNumbers);
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", listOfNumbers));
            Console.Write("]");
            Console.WriteLine();


        }

        public static List<int> AddNumber(int index, int element, List<int> listOfNumbers)
        {
            listOfNumbers.Insert(index, element);

            return listOfNumbers;
        }
        public static List<int> AddManyNumbers(int index, List<int> listOfNumbersForAdding, List<int> listOfNumbers)
        {
            listOfNumbers.InsertRange(index, listOfNumbersForAdding);

            return listOfNumbers;
        }
        public static void ContainsElement(int number, List<int> listOfNumbers)
        {
            if (listOfNumbers.Contains(number))
            {
                Console.WriteLine(listOfNumbers.IndexOf(number));
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
        public static List<int> RemoveElement(int index, List<int> listOfNumbers)
        {
            listOfNumbers.RemoveAt(index);

            return listOfNumbers;
        }
        public static List<int> ShiftingElements(int n, List<int> listOfNumbers)
        {
            
            for (int i = 0; i < n; i++)
            {
                var firstElement = listOfNumbers[0];
                for (int element = 0; element < listOfNumbers.Count - 1; element++)
                {
                    
                    listOfNumbers[element] = listOfNumbers[element + 1];
                }
                listOfNumbers[listOfNumbers.Count - 1] = firstElement;
            }
            return listOfNumbers;
        }
        public static List<int> SumOfPairsNumbers(List<int> listOfNumbers)
        {
            var result = new List<int>();
            for (int i = 0; i < listOfNumbers.Count - 1; i++)
            {
                var sum = listOfNumbers[i] + listOfNumbers[i + 1];
                result.Add(sum);
                i++;
            }
            if (listOfNumbers.Count % 2 != 0)
            {
                result.Add(listOfNumbers[listOfNumbers.Count - 1]);
            }
            listOfNumbers.Clear();
            listOfNumbers.AddRange(result);

            return listOfNumbers;
        }
    }
}
