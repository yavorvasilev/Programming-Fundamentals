using System.IO;
using System.Linq;

namespace _5FolderSize
{
    public class FolderSize
    {
        public static void Main()
        {
            //var files = Directory
            //    .GetFiles("TestFolder")
            //    .Select(f => new FileInfo(f))
            //    .Sum(f => f.Length / 1024.0 / 1024.0);

            var currentFiles = Directory.GetFiles("TestFolder");

            var totalLength = 0L;

            foreach (var file in currentFiles)
            {
                var fileInfo = new FileInfo(file);
                totalLength += fileInfo.Length;
            }

            System.Console.WriteLine(totalLength / 1024.0 / 1024.0);
        }
    }
}
