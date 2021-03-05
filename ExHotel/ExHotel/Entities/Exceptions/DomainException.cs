using System;
using System.Collections.Generic;
using System.Text;

namespace ExHotel.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base (message)
        {
            //Construtor que chama o construtor da classe genérica
        }
    }
}
