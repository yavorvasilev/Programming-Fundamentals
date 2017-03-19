using System;
using System.Linq;
using System.Collections.Generic;

namespace _7AndreyAndBilliard
{
    public class AndreyAndBilliard
    {
        public static void Main()
        {
            var numberOfEntities = int.Parse(Console.ReadLine());

            var menu = new Dictionary<string, decimal>();

            for (int i = 0; i < numberOfEntities; i++)
            {
                var entite = Console.ReadLine().Split('-');
                var nameOfProduct = entite[0];
                var price = decimal.Parse(entite[1]);

                if (!menu.ContainsKey(nameOfProduct))
                {
                    menu[nameOfProduct] = price;
                }
                menu[nameOfProduct] = price;
            }

            
            var listOfCustomers = new List<Customer>();

            var order = Console.ReadLine().Split(',', '-');

            while (order[0] != "end of clients")
            {
                var customerName = order[0];
                var orderedProduct = order[1];
                var quantity = int.Parse(order[2]);
                var customer = new Customer();
                customer.Name = customerName;
                customer.Order = new Dictionary<string, int>();

                if (menu.ContainsKey(orderedProduct))
                {
                    if (listOfCustomers.Any(x => x.Name == customerName))
                    {
                        foreach (var item in listOfCustomers)
                        {
                            if (item.Name == customerName)
                            {
                                foreach (var product in item.Order)
                                {
                                    if (product.Key == orderedProduct)
                                    {
                                        item.Order[orderedProduct] = product.Value + quantity;
                                        item.Bill += quantity * menu[orderedProduct];
                                        break;
                                    }
                                    else
                                    {
                                        item.Order[orderedProduct] = quantity;
                                        item.Bill += quantity * menu[orderedProduct];
                                        break;
                                    }
                                }
                                break;       
                            }
                        }
                    }

                    else
                    {
                        if (!customer.Order.ContainsKey(orderedProduct))
                        {
                            customer.Order[orderedProduct] = quantity;
                            customer.Bill += quantity * menu[orderedProduct];
                            listOfCustomers.Add(customer);
                        }
                    }

                   
                }
                order = Console.ReadLine().Split(',', '-');
            }

            foreach (var client in listOfCustomers.OrderBy(x => x.Name))
            {
                Console.WriteLine(client.Name);

                foreach (var orders in client.Order)
                {
                    Console.WriteLine($" -- {orders.Key} - {orders.Value}");
                }

                Console.WriteLine($"Bill: {client.Bill:F2}");
            }
            Console.WriteLine($"Total bill: {listOfCustomers.Sum(x => x.Bill):F2}");

        }
    }
}
