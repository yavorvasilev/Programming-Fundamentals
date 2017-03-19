using System;

namespace _1DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            var dayOfWeek = new string [] {"Monday" , "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(dayOfWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
