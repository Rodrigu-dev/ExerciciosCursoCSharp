using System;
using System.Collections.Generic;
using System.Text;


namespace ExHera_Poli_Proposto.Entities
{
    class PessoaFisica : Contribuintes
    {
        public double RendaAnualPf { get; set; }
        public double GastoSaude { get; set; }

        public PessoaFisica(string name, double rendaAnualPf, double gastoSaude)
            : base(name)
        {
            RendaAnualPf = rendaAnualPf;
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            if (RendaAnualPf >= 20000)
            {
                return (RendaAnualPf * 0.25) - (GastoSaude * 0.50);
            }
            else
            {
                return (RendaAnualPf * 0.15) - (GastoSaude * 0.50);
            }
                       
            
        }
    }
}
