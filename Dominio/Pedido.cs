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
        private Deliveryman deliveryAsociado;

        public Service Service { get => service; set => service = value; }

        public Client Client { get => client; set => client = value; }

        public DateTime Date { get => date; set => date = value; }

        public Deliveryman DeliveryAsociado { get => deliveryAsociado; set => deliveryAsociado = value; }


        public Pedido(Service service, Client client)
        {
            this.service = service;
            this.client = client;
            this.date = DateTime.Now;
        }

        public Pedido(Service service, Client client, Deliveryman delivery)
        {
            this.service = service;
            this.client = client;
            this.date = DateTime.Now;
            this.deliveryAsociado=delivery;
        }

        public override string ToString()
        {
            return $"{service} || {client} || {date} || Delivery: {deliveryAsociado.Name}";
        }
    }
}
