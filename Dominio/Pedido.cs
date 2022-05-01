using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Pedido
    {
        private Service service;
        private Client client;
        private DateTime date;

        public Service Service { get => service; set => service = value; }


        public Client Client { get => client; set => client = value; }

        public DateTime Date { get => date; set => date = value; }



        public Pedido(Service service, Client client)
        {
            this.service = service;
            this.client = client;
            this.date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{service} || {client} || {date}";
        }
    }
}
