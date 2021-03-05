using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExEnum_Composicao.Entities.Enums;
using ExEnum_Composicao.Entities;

namespace ExEnum_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter cliente data: ");
            string nameClient = Console.ReadLine();
            Console.Write("E-mail: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
           
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), out status);

            
            
            Client client = new Client(nameClient, emailCliente, birthDay);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order? ");
            int quantItens = int.Parse(Console.ReadLine());
            
            
            for (int i = 1; i <= quantItens; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Produtct Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product Price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, priceProduct);
                OrderItem orderItem = new OrderItem(quant, priceProduct, product);
                order.AddItem(orderItem);
                     
                
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);

          

                  

            Console.ReadKey();
        }
    }
}
