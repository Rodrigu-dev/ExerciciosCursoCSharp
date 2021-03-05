using System;
using ExHera_Poli_Proposto.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExHera_Poli_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> list = new List<Contribuintes>();
            double sum = 0.0;

            Console.Write("Enter the number of tax payers: ");
            int numContribuinte = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numContribuinte; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char tipo = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(name, renda, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, renda, employees));

                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (Contribuintes cont in list)
            {
                
                Console.WriteLine(cont.Name + " : " + cont.Imposto().ToString("F2", CultureInfo.InvariantCulture));
                sum += cont.Imposto();
            }
                     

            Console.WriteLine();
            Console.Write("Total Taxes: ");
            Console.WriteLine(sum.ToString ("F2", CultureInfo.InvariantCulture));


            Console.ReadKey();
        }
    }
}
