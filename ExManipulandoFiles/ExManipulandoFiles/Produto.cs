using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExManipulandoFiles
{
    class Produto
    {
        public string Nome { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {

        }
        public Produto(string nome, double valorUnitario, int quantidade)
        {
            Nome = nome;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;

        }

        public double Total()
        {
            
            return ValorUnitario * Quantidade;
        }

    }
}
