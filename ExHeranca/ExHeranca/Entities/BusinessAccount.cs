namespace ExHeranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) // Loan = Emprestimo
        {
            if (amount <= LoanLimit) // testar se a quantia de emprestimo é menor ou igual ao Limite
            {
                Balance += amount;
            }
           
        }
    }
}
