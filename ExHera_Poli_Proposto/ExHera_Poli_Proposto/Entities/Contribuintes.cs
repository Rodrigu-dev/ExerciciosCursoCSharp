using System;
using System.Collections.Generic;
using System.Text;

namespace ExHera_Poli_Proposto.Entities
{
    abstract class Contribuintes
    {
        public string Name { get; set; }

        public Contribuintes(string name)
        {
            Name = name;
        }

        public abstract double Imposto();
      
    }
}
