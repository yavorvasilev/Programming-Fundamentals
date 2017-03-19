using System;
using System.Collections.Generic;
using System.Linq;

namespace _2PhonebookWithFunctionListAll
{
    public class PhonebookUpgrade
    {
        public static void Main()
        {

            var phonebook = new Dictionary<string, string>();
            var command = new List<string>();

            do
            {
                command = Console.ReadLine().Split(' ').ToList();

                if (command[0] == "A")
                {
                    phonebook[command[1]] = command[2];
                }
                else if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", command[1]);
                    }
                }
                else if (command[0] == "ListAll")
                {
                    ListAll(phonebook);
                }

            } while (!(command[0] == "END"));
        }


        public static void ListAll(Dictionary<string, string> phonebook)
        {
            var sortedDictionary = new SortedDictionary<string, string>();
            foreach (var item in phonebook)
            {
                sortedDictionary.Add(item.Key,item.Value);
            }
            foreach (var item in sortedDictionary)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
