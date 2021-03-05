using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoSalario.Entities.Enums;
using CalculoSalario.Entities;
using System.Globalization;

namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's Name: ");
            string depName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level;
            Enum.TryParse(Console.ReadLine(), out level); // Ou => "WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());"
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Instanciando dois objetos.
            Department dept = new Department(depName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int quantContratos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantContratos; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours):");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(data, valuePerHour, hours);
                worker.AddContract(contract);  
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for: " + monthAndYear + ": " + worker.Income(year, month));

            Console.ReadKey();
        }
    }
}
