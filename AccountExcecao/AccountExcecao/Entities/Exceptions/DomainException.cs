using System;
using System.Collections.Generic;
using System.Text;

namespace AccountExcecao.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
            //Construtor que chama o construtor da classe genérica
        }
    }
}
