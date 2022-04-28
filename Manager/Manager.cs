
using System.Collections.Generic;
using static System.Console;
using Dominio;
using System;

namespace Manager
{
    public class Manager
    {

        private List<Dish> dishes = new List<Dish>();
        private List<Client> clients = new List<Client>();
        private List<Waiter> waiters = new List<Waiter>();
        private List<Service> services = new List<Service>();
        private List<Deliveryman> repartidores = new List<Deliveryman>();


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
        public void ListarWaiters()
        {
            foreach (var waiter in Waiters)
            {
                WriteLine(waiter);
            }
        }

        public void ListarDeliveries(DateTime from, DateTime to)
        {

            List<Delivery> listaDeliveries = new List <Delivery>();
            foreach(var service in services)
            {

                if (service is Delivery)
                {
                    Delivery delivery = (Delivery)service;
                    if (delivery.Date > from && delivery.Delivered < to) 
                    {
                        listaDeliveries.Add(delivery);
                        WriteLine("  »  " + delivery);
                    }
                    

                }

            }
            WriteLine("\n\nPresione Enter para volver, cualquier otra tecla para salir.");
            WriteLine("\n───────────────────────────────────────────────────────────────");
            if (listaDeliveries.Count == 0)
            {
                WriteLine("\n\nNo hay deliveries hechos en ese rango de fechas");
                WriteLine("\n\n\n\n\n───────────────────────────────────────────────────────────────\nPresione Enter para volver, cualquier otra tecla para salir.");
            }

            
        }
        public void PrecargarDatos()
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

            Waiter waiter1 = AltaMozo("Hernan", "Pereira");
            Waiter waiter2 = AltaMozo("Florencia", "Sánchez");
            Waiter waiter3 = AltaMozo("Facundo", "Ricaldoni");
            Waiter waiter4 = AltaMozo("Romina", "Hernández");
            Waiter waiter5 = AltaMozo("Sofía", "Siena");

            Delivery delivery1 = AltaDelivery(DateTime.Now, "Calle Falsa 122", 20, new List<Dish>() {plato1, plato2});
            Delivery delivery2 = AltaDelivery(DateTime.Now, "Calle Falsa 126", 20, new List<Dish>() { plato5, plato10, plato6 });
            Delivery delivery3 = AltaDelivery(DateTime.Now, "Calle Falsa 123", 20, new List<Dish>() { plato6});
            Delivery delivery4 = AltaDelivery(DateTime.Now, "Calle Falsa 123", 20, new List<Dish>() { plato3, plato4 });
            Delivery delivery5 = AltaDelivery(DateTime.Now, "Calle Falsa 123", 20, new List<Dish>() { plato9, plato8 });

            Client cliente1 = AltaCliente("Agustina", "Balsas", "ggnacio@hotmail.com", "agustina1B");
            Client cliente2 = AltaCliente("Ignacio", "Ribas", "alejo@gmail.com", "ignacio1R");
            Client cliente3 = AltaCliente("Alejo", "Krucheff", "alejo@outlook.com", "agustina1B");
            Client cliente4 = AltaCliente("Anaru", "Martínez", "anaru@gmail.com", "Anaru1");
            Client cliente5 = AltaCliente("Juan", "Rodríguez", "juanr@outlook.com", "juanR13");

            Local local1 = AltaLocal(DateTime.Now, 2, cliente1, new List<Dish>() { plato1, plato2 });
            Local local2 = AltaLocal(DateTime.Now, 4, cliente2, new List<Dish>() { plato6, plato5 });
            Local local3 = AltaLocal(DateTime.Now, 7, cliente3, new List<Dish>() { plato10 });
            Local local4 = AltaLocal(DateTime.Now, 1, cliente4, new List<Dish>() { plato8, plato4 });
            Local local5 = AltaLocal(DateTime.Now, 3, cliente5, new List<Dish>() { plato9, plato10, plato5 });

            Deliveryman repartidor1 = AltaRepartidor("Agustina", "Balsas", Vehicle.Moto);
            Deliveryman repartidor2 = AltaRepartidor("Juan", "Pérez", Vehicle.Bicicleta);
            Deliveryman repartidor3 = AltaRepartidor("Gonzalo", "Pereira", Vehicle.Pie);
            Deliveryman repartidor4 = AltaRepartidor("Alejandro", "Marella", Vehicle.Bicicleta);
            Deliveryman repartidor5 = AltaRepartidor("Roberto", "Sánchez", Vehicle.Moto);
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

        public Waiter AltaMozo(string name, string last_name)
        {
            bool validado = Waiter.ValidWaiter(name, last_name);

            if (validado == false)
                return null;

            Waiter waiter = new Waiter(name, last_name);

            if (Waiters.Contains(waiter))
                waiter = null;
            else
                waiters.Add(waiter);

            return waiter;
        }

        public Deliveryman AltaRepartidor(string name, string last_name, Vehicle vehicle)
        {
            bool validado = Deliveryman.ValidoRepartidor(name, last_name);

            if (validado == false)
                return null;

            if (vehicle == Vehicle.Moto)
            {
                vehicle = Vehicle.Moto;
            }

            Deliveryman repartidor = new Deliveryman(name, last_name, vehicle);

            if (Deliverymen.Contains(repartidor))
                repartidor = null;
            else
                repartidores.Add(repartidor);

            return repartidor;
        }

        public Delivery AltaDelivery(DateTime date, string address, float distance, List<Dish> dishes)
        {
            Delivery delivery = new Delivery(date, address, distance, dishes);
            services.Add(delivery);
            return delivery;
        }

        public Local AltaLocal(DateTime date, int table, Client cliente, List<Dish> dishes)
        {
            Local local = new Local(date, table, dishes);

            local.AddGuest(cliente);
            services.Add(local);
            return local;
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

        public List<Deliveryman> Deliverymen
        {
            get
            {
                return repartidores;
            }

            set
            {
                repartidores = value;
            }
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
        public List<Service> Services
        {
            get
            {
                return services;
            }

            set
            {
                services = value;
            }
        }
    }
}