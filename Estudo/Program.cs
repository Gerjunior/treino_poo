using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo.Entities;
using Estudo.Entities.Enums;

namespace Estudo
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
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            Enum.TryParse(Console.ReadLine(), out OrderStatus status);

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status, client);


            Console.Write("How many items to this order? ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = Convert.ToDouble(Console.ReadLine());

                Product product = new Product(productName, productPrice);


                Console.Write("Quantity: ");
                int productQuantity = Convert.ToInt32(Console.ReadLine());

                OrderItem item = new OrderItem(productQuantity, productPrice, product );
                order.AddItem(item);

            }

            Console.WriteLine("ORDER SUMMARY:\n");
            Console.WriteLine(order);
        }
    }
}
