
using System.Collections.Generic;
using static System.Console;
using Dominio;

namespace Manager
{
    public class Manager
    {

        private List<Dish> dishes = new List<Dish>();
        private List<Client> clients = new List<Client>();
        private List<Waiter> waiters = new List<Waiter>();
        private List<Deliveryman> deliverymen = new List<Deliveryman>();



        public Manager()
        {
            PrecargarDatos();
        }

        public void ListarPlatos()
        {
            foreach (var dish in Dishes)
            {
                WriteLine(dish);
            }
        }
        public void ListarClientes()
        {
            Clients.Sort(Client.CompareByLastName);
            foreach (var client in Clients)
            {
                WriteLine(client);
            }
        }
        public void ListarWaiters()
        {
            foreach (var waiter in Waiters)
            {
                WriteLine(waiter);
            }
        }

        public void ListarDeliveryMen()
        {
            foreach (var deliveryman in Deliverymen)
            {
                WriteLine(deliveryman);
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

        public void PrecargarWaiters()
        {
            Waiter waiter1 = AltaMozo("Hernan", "Pereira");
            Waiter waiter2 = AltaMozo("Florencia", "Sánchez");
            Waiter waiter3 = AltaMozo("Facundo", "Ricaldoni");
            Waiter waiter4 = AltaMozo("Romina", "Hernández");
            Waiter waiter5 = AltaMozo("Sofía", "Siena");
        }

        public void PrecargarDeliveryMen()
        {
            Deliveryman deliveryman1 = AltaRepartidor("Roberto", "Fernandez", Vehicle.Bicicleta);
            Deliveryman deliveryman2 = AltaRepartidor("Mirtha", "Hernandez", Vehicle.Moto);
            Deliveryman deliveryman3 = AltaRepartidor("Fernando", "Perez", Vehicle.Moto);
            Deliveryman deliveryman4 = AltaRepartidor("Josefina", "Salomé", Vehicle.Bicicleta);
            Deliveryman deliveryman5 = AltaRepartidor("Felipe", "Martínez", Vehicle.Pie);
        }

        public void PrecargarDatos()
        {
            PrecargarDishes();
            PrecargarClients();
            PrecargarWaiters();
            PrecargarDeliveryMen();
        }

        public Client AltaCliente(string name, string last_name, string email, string password)
        {
            bool validado = Client.IsValid(name, last_name, email, password);

            if (!validado)
                return null;

            Client cliente = new Client(name, last_name, email, password);

            if (Clients.Contains(cliente))
                cliente = null;
            else
                clients.Add(cliente);

            return cliente;
        }
        public Waiter AltaMozo (string name, string last_name)
        {
            bool validado = Waiter.ValidWaiter(name, last_name);

            if (!validado)
                return null;

            Waiter waiter = new Waiter(name, last_name);

            if (Waiters.Contains(waiter))
                waiter = null;
            else
                waiters.Add(waiter);

            return waiter;
        }

        public Deliveryman AltaRepartidor (string name, string last_name, Vehicle vehicle)
        {
            bool validado = Deliveryman.ValidoDatos(name,last_name);

            if (!validado)
                return null;

            Deliveryman deliveryman = new Deliveryman(name, last_name, vehicle);

            if (Deliverymen.Contains(deliveryman))
                deliveryman = null;
            else
                deliverymen.Add(deliveryman);

            return deliveryman;
        }

        public Service AltaServcio ()
        {
            return null;
        }

        public Dish AltaPlato(string name, float price)
        {
            bool validado = Dish.ValidarDatos(name, price);

            if (!validado)
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
        public List<Waiter> Waiters
        {
            get
            {
                return waiters;
            }

            set
            {
                waiters = value;
            }
        }

        public List<Deliveryman> Deliverymen
        {
            get
            {
                return deliverymen;
            }

            set
            {
                deliverymen = value;
            }
        }
    }
}