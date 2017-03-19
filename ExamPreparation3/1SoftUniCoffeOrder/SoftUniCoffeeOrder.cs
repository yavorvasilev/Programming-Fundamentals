using System;
using System.Globalization;

namespace _1SoftUniCoffeOrder
{
    public class SoftUniCoffeeOrder
    {
        public static void Main()
        {
            var numberOfOrders = int.Parse(Console.ReadLine());
            var sum = 0M;

            for (int i = 0; i < numberOfOrders; i++)
            {
                var priceOfCapsule = decimal.Parse(Console.ReadLine());

                var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

                var capsulesCount = long.Parse(Console.ReadLine());

                var days = DateTime.DaysInMonth(date.Year, date.Month);

                var priceOfTheCoffee = days * capsulesCount * priceOfCapsule;

                sum += priceOfTheCoffee;

                Console.WriteLine($"The price for the coffee is: ${priceOfTheCoffee:F2}");                                     
            }

            Console.WriteLine($"Total: ${sum:F2}");
        }
    }
}
