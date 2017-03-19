using System.IO;
using System.Collections.Generic;

namespace _2LineNumbers
{
    public class LineNumbers
    {
        public  static void Main()
        {
            var file = "input.txt";

            var lines = File.ReadAllLines(file);

            var linesWirhNumbers = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                linesWirhNumbers.Add($"{i + 1}. {lines[i]}");
            }

            File.WriteAllLines("output.txt", linesWirhNumbers);
        }
    }
}
