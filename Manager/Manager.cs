
using System.Collections.Generic;
using static System.Console;
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

        public void ListarPlatos()
        {
            foreach (var dish in Dishes)
            {
                WriteLine("  »  " + dish);
            }
        }
        public void ListarClientes()
        {
            Clients.Sort(Client.CompareByLastName);
            
            foreach (var client in Clients)
            {
                WriteLine("  »  " + client);
            }

        }

        public void PrecargarDishes ()
        {
            Dish plato1 = AltaPlato("Sushi", 490);
            Dish plato2 = AltaPlato("Ñoquis", 600);
            Dish plato3 = AltaPlato("Pizza", 490);
            Dish plato4 = AltaPlato("Napolitana", 660);
            Dish plato5 = AltaPlato("Ensalada", 390);
            Dish plato6 = AltaPlato("Chivito", 550);
            Dish plato7 = AltaPlato("Rabas", 900);
            Dish plato8 = AltaPlato("Sandwich Caliente", 220);
            Dish plato9 = AltaPlato("Pollo", 450);
            Dish plato10 = AltaPlato("Hamburguesa", 350);
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

        public void PrecargarDeliveries ()
        {

        }

        public Client AltaCliente(string name, string last_name, string email, string password)
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
        //public Waiter AltaMozo (string name, string last_name, int wnum)
        //{
            //falta implementar dijo nachito
        //}
        public Deliveryman AltaRepartidor (string name, string last_name)
        {
            return null;
        }
        public Service AltaServcio ()
        {
            return null;
        }
        public Dish AltaPlato(string name, float price)
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