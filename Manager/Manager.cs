
using System.Collections.Generic;
using Dominio;

namespace Manager
{
    public class Manager
    {
        private List<Dish> dishes = new List<Dish>();
        private List<Client> clients = new List<Client>();

        public Manager()
        {
            PrecargarDatos();
        }

        public void PrecargarDishes ()
        {
            Dish plato1 = AltaPlatos("Sushi", 490);
            Dish plato2 = AltaPlatos("Ñoquis", 600);
            Dish plato3 = AltaPlatos("Pizza", 490);
            Dish plato4 = AltaPlatos("Napolitana", 660);
            Dish plato5 = AltaPlatos("Ensalada", 390);
            Dish plato6 = AltaPlatos("Chivito", 550);
            Dish plato7 = AltaPlatos("Rabas", 900);
            Dish plato8 = AltaPlatos("Sandwich Caliente", 220);
            Dish plato9 = AltaPlatos("Pollo", 450);
            Dish plato10 = AltaPlatos("Hamburguesa", 350);
        }

        public void PrecargarClients()
        {
            Client cliente1 = AltaCliente("Agustina", "Balsas", "ggnacio@hotmail.com", "agustina1B");
            Client cliente2 = AltaCliente("Ignacio", "Ribas", "alejo@gmail.com", "ignacio1R");
            Client cliente3 = AltaCliente("Alejo", "Krucheff", "alejo@outlook.com", "agustina1B");
            Client cliente4 = AltaCliente("Anaru", "Martínez", "anaru@gmail.com", "Anaru1");
            Client cliente5 = AltaCliente("Juan", "Rodríguez", "juanr@outlook.com", "juanR13");

        }

        public void PrecargarDatos()
        {
            PrecargarDishes();
            PrecargarClients();
        }

        public Client AltaCliente (string name, string last_name, string email, string password)
        {
            bool validado = Client.IsValid(name, last_name, email, password);

            if (validado == false)
                return null;

            Client cliente = new Client(name, last_name, email, password);

            if (Clients.Contains(cliente))
                cliente = null;
            else
                clients.Add(cliente);

            return cliente;
        }

        public Dish AltaPlatos(string name, float price)
        {
            bool validado = Dish.ValidarDatos(name, price);

            if (validado == false)
                return null;

            Dish plato = new Dish(name, price);

            if (Dishes.Contains(plato))
                plato = null;
            else
                Dishes.Add(plato);

            return plato;
        }

        public List<Client> Clients
        {
            get
            {
                return clients;
            }

            set
            {
                clients = value;
            }
        }

        public List<Dish> Dishes
        {
            get
            {
                return dishes;
            }

            set
            {
                dishes = value;
            }
        }
    }
}