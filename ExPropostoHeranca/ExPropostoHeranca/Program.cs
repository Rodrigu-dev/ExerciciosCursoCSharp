using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExPropostoHeranca.Entities;

namespace ExPropostoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();
           

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (op)
                {
                    case ('i'):
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        list.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    case ('u'):
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufacture = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, manufacture));
                        break;
                    case ('c'):
                        list.Add(new Product(name, price));
                        break;
                    default:
                        break;
                }
  
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }





            Console.ReadKey();
        }
    }
}
