using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            Console.WriteLine("-------------Converter ENUM em String-----------------");

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            Console.WriteLine("-------------Converter String em ENUM-----------------");
            OrderStatus os;
            Enum.TryParse("Delivered", out os);
            Console.WriteLine(os);

           

            Console.ReadKey();
        }
    }
}
