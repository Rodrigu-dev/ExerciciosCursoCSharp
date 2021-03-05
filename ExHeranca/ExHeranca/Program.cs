using ExHeranca.Entities;

namespace ExHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1000, "Alex", 0.0);
            BusinessAccount bcc = new BusinessAccount(1001, "Pedro", 0.0, 500.0);

            // UPCASTING 

            Account acc1 = bcc;
            Account acc2 = new BusinessAccount(1003, "Pedro", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Maria", 0.0, 0.01);

            // DOWCASTING ( é uma operação insegura)

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }


        }
    }
}
