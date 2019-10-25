using System;
using PedidosDoCliente.Enums;
using System.Globalization;
using System.Collections.Generic;

namespace PedidosDoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order? ");
            int n = Convert.ToInt32(Console.ReadLine());
            Client client = new Client(name, email, date);
            Order or = new Order(DateTime.Now, status);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, price);
                OrderItem o = new OrderItem(quantity, price, product);
                or.AddItem(o);
                
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine("Order Moment: " + DateTime.Now);
            Console.WriteLine("Order Status: " + status);
            Console.WriteLine($"Client: {name} {date} - {email}");
            Console.WriteLine("Order Items: ");
            foreach(OrderItem novoItem in or.Item)
            {
                Console.WriteLine($"{novoItem.Products.ProductName} - ${novoItem.Price.ToString("F2",CultureInfo.InvariantCulture)} " +
                    $"- Quantity:{novoItem.Quantity} - Subtotal: ${novoItem.SubTotal().ToString("F2", CultureInfo.InvariantCulture)} ");
                Console.WriteLine();
            }
            
            
            Console.WriteLine("Total price: $" + or.Total().ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
            
        }
    }
}
