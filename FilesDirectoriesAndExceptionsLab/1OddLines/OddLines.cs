using System.IO;
using System.Collections.Generic;

namespace _1OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            var file = "myfile.txt";

            var lines = File.ReadAllLines(file);

            //if (!File.Exists("result.txt"))
            //{
            //    File.Create("result.txt");
            //}

            var oddLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(lines[i]);
                }
            }

            File.WriteAllLines("result.txt", oddLines);
        }
    }
}
