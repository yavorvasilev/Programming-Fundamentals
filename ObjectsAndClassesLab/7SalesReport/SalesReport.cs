using System;
using System.Collections.Generic;
using System.Linq;

namespace _7SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            var listOfSale = new List<Sale>();

            var numberOfSales = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSales; i++)
            {
                var inputSale = Console.ReadLine().Split();

                var town = inputSale[0];
                var product = inputSale[1];
                var price = decimal.Parse(inputSale[2]);
                var quantity = decimal.Parse(inputSale[3]);

                var sale = new Sale
                {
                    Town = town,
                    Product = product,
                    Price = price,
                    Quantity = quantity
                };

                listOfSale.Add(sale);
            }

            var listOfTown = new SortedDictionary<string, decimal>();
            var sum = 0m;

            foreach (var sale in listOfSale.OrderBy(x => x.Town))
            {
                foreach (var item in listOfSale)
                {
                    if (sale.Town == item.Town)
                    {
                        sum += item.Price * item.Quantity;
                    }
                }
                if (!listOfTown.ContainsKey(sale.Town))
                {
                    listOfTown[sale.Town] = sum;
                }
                sum = 0;
            }

            foreach (var item in listOfTown)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }

        }
    }
}
