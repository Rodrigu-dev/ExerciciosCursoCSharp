using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExInterface.Entities;

namespace ExInterface.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

       
        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int parc)
        {
            double valorParcela = contract.TotalValue / parc;

            for (int i = 1; i <= parc; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double interest = valorParcela + _paymentService.Interest(valorParcela, i);
                double paymentFee = interest + _paymentService.PaymentFee(interest);          
                contract.AddInstallment(new Installment(date, paymentFee));
            }

            
        }
    }
}
