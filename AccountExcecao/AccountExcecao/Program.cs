using System;
using AccountExcecao.Entities;
using AccountExcecao.Entities.Exceptions;

namespace ExcecaoAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Enter account data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw Limit: ");
            double withdrawLimite = double.Parse(Console.ReadLine());

            Account acc = new Account(number, holder, balance, withdrawLimite);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amountWithdraw = double.Parse(Console.ReadLine());
            try
            {
                acc.Withdraw(amountWithdraw);
                Console.WriteLine(acc);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);

            }

            Console.ReadKey();

        }
    }
}