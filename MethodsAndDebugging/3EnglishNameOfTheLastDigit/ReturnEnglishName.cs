using System;

namespace _3EnglishNameOfTheLastDigit
{
    public class ReturnEnglishName
    {
        public static void Main()
        {

            var number = long.Parse(Console.ReadLine());
            var lastDigit = GetLastDigit(number);
            GetEnglishName(Math.Abs(lastDigit));

        }

        public static long GetLastDigit(long number)
        {
            var lastDigit = number % 10;
            //Console.WriteLine(lastDigit);

            return lastDigit;
        }

        public static void GetEnglishName(long lastDigit)
        {
            switch (lastDigit)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
            }
        }
    }
}
