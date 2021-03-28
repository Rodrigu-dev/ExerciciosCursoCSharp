using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExInterface.Entities;
using ExInterface.Services;

namespace ExInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double valueContract = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numberParc = int.Parse(Console.ReadLine());
                  
            Contract contract = new Contract(number,date, valueContract);

            ContractService contractService = new ContractService(new PaymentService());

            contractService.ProcessContract(contract, numberParc);

            Console.WriteLine("Installment: ");

            foreach (var installment in contract.Installment)
            {
                Console.WriteLine(installment);
            }

            Console.ReadKey();


        }
    }
}
