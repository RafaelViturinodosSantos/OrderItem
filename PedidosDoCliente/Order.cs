using System;
using System.Collections.Generic;
using System.Text;
using PedidosDoCliente.Enums;

namespace PedidosDoCliente
{
    class Order
    {
        public DateTime Moment { get; protected set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }
        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Item)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}
