using System;
using System.Collections.Generic;
using System.Text;

namespace ExHera_Poli_Proposto.Entities
{
    class PessoaJuridica : Contribuintes
    {
        public double RendaAnualPj { get; set; }
        public int NumEmployees { get; set; }

        public PessoaJuridica(string name, double rendaAnualPj, int numEmployees)
            : base(name)
        {
            RendaAnualPj = rendaAnualPj;
            NumEmployees = numEmployees;
        }

        public override double Imposto()
        {
            if (NumEmployees >= 10)
            {
                return RendaAnualPj * 0.14;
            }
            else
            {
                return RendaAnualPj * 0.16;
            }
                       
        }
    }
}
