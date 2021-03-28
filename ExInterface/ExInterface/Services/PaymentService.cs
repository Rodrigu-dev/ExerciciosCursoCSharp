using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterface.Services
{
    class PaymentService : IPaymentService
    {
        private const double PercentFee = 0.02;
        private const double PercentInterest = 0.01;
        public double Interest(double amount, int months) //Juros
        {
                 
            return amount * PercentInterest * months;
        }

        public double PaymentFee(double amount) // Pagamento Taxa
        {
            
            return amount * PercentFee;
        }
    }
}
