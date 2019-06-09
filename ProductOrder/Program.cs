using System;
using System.Globalization;
using ProductOrder.Entities;
using ProductOrder.Entities.Enums;

namespace ProductOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(name, email, birthDate, DateTime.Now, status);

            Console.Write("How many items to this order? ");
            int qtde = int.Parse(Console.ReadLine());

            for (int x = 1; x <= qtde; x++)
            {
                Console.WriteLine($"Enter #{x} item data: ");
                Console.Write("Product name: ");
                string pname = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int pqtde = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(pname, pqtde, price);
                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
