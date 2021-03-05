using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPropostoHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return Price + 20;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice() + " (Customs free: $ 20.00) ";
        }
    }
}
