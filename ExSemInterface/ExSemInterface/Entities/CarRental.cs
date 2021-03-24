using System;

namespace ExSemInterface.Entities
{
    //CLASSE DE DOMÍNIO
    class CarRental  
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;  // somente para ficar didático, o sistema já faz isso. Objeto associado já recebe nulo
        }


    }
}
