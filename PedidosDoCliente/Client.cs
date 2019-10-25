using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosDoCliente
{
    class Client
    {
        public string Name { get; protected set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; private set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
