using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4Files
{
    class Files
    {
        static void Main(string[] args)
        {
            var numberOfFiles = int.Parse(Console.ReadLine());

            var filesByRoots = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < numberOfFiles; i++)
            {
                var filesPathInput = Console.ReadLine();

                var filesSize = long.Parse(filesPathInput.Split(new char[] { ';' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Last()
                    .Trim());

                var filePath = filesPathInput.Split(new char[] { ';' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .First()
                    .Trim();

                var fileName = filePath.Split('\\').Last().Trim();

                var root = filePath.Split('\\').First().Trim();

                if (!filesByRoots.ContainsKey(root))
                {
                    filesByRoots.Add(root, new Dictionary<string, long>());
                }
                if (!filesByRoots[root].ContainsKey(fileName))
                {
                    filesByRoots[root].Add(fileName, filesSize);
                }
                else
                {
                    filesByRoots[root][fileName] = filesSize;
                }
            }

            var queryStrings = Console.ReadLine()
                .Split(new char[] {' '}
                ,StringSplitOptions
                .RemoveEmptyEntries);
            var queryExt = queryStrings.First();
            var queryRoot = queryStrings.Last();

            if (filesByRoots.ContainsKey(queryRoot))
            {
                var foundFiles = filesByRoots[queryRoot];

                foreach (var file in foundFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (file.Key.EndsWith(queryExt))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
