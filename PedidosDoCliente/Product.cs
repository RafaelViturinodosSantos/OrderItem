using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosDoCliente
{
    class Product
    {
        public string ProductName { get; protected set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
