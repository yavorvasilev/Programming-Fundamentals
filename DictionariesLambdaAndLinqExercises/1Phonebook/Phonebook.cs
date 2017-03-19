using System;
using System.Collections.Generic;
using System.Linq;

namespace _1Phonebook
{
    public class Phonebook
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
                        Console.WriteLine("{0} -> {1}",command[1], phonebook[command[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", command[1]);
                    }
                } 
            } while (!(command[0] == "END"));
        }
    }
}
