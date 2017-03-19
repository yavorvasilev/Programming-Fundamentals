using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadingTime = long.Parse(Console.ReadLine());

            var timeForFiltering = numberOfPictures * filterTime;
            var goodPictures = Math.Ceiling(((decimal)numberOfPictures * filterFactor) / 100);
            var timeForUploading = goodPictures * uploadingTime;

            var totalSeconds = timeForFiltering + (long)timeForUploading;
            var totalTime = TimeSpan.FromSeconds(totalSeconds);
            //Console.WriteLine(TimeSpan.FromSeconds(Convert.ToDouble(totalSeconds)));
            //Console.WriteLine(TimeSpan.FromSeconds((totalSeconds)));

            //if (totalTime.Days > 0)
            //{
            //    Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));
            //}

            Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));

        }
    }
}
