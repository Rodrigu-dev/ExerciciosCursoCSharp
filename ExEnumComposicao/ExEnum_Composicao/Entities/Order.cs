using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExEnum_Composicao.Entities.Enums;
using ExEnum_Composicao.Entities;

namespace ExEnum_Composicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
       
        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach ( OrderItem item in Itens)
            {
                sum += item.SubTotal();
            }
            
            
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Ordem Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Item: ");
            foreach (OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
           
            sb.AppendLine("Total price: $" + Total().ToString());
            return sb.ToString();

        }

    }

}
