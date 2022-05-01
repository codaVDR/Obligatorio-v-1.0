
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
        private List<Pedido> pedidos = new List<Pedido>();


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

        public void ListarPedidos()
        {
            foreach (var pedido in Pedidos)
            {
                WriteLine(pedido);
            }
        }

        public void ListarDeliveries(DateTime from, DateTime to)
        {
            List<Pedido> listaPedidos = new List<Pedido>();
            foreach (var pedido in pedidos)
            {
                if (pedido.Service is Delivery)
                {
                    Delivery delivery = (Delivery)pedido.Service;
                    if (pedido.Date > from && delivery.Delivered < to)
                    {
                        listaPedidos.Add(pedido);
                        WriteLine("\n");
                        ForegroundColor = ConsoleColor.Cyan;
                        WriteLine("  »  " + pedido);
                        foreach (var dish in pedido.Service.Dishes)
                        {
                            WriteLine("  »  »  " + dish);
                        }
                        ForegroundColor = ConsoleColor.Green;
                    }
                }
            }

            WriteLine("\n───────────────────────────────────────────────────────────────");
            if (listaPedidos.Count == 0)
            {
                WriteLine("\nNo hay deliveries hechos en ese rango de fechas");
                WriteLine("\n───────────────────────────────────────────────────────────────\n");
            }
            WriteLine("\nPresione Enter para volver, cualquier otra tecla para salir.");
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

            Delivery delivery1 = AltaDelivery(DateTime.Now, "Calle Falsa 122", 20, new List<Dish>() {plato1, plato7});
            Delivery delivery2 = AltaDelivery(DateTime.Now, "Calle Falsa 126", 20, new List<Dish>() { plato5, plato10, plato6 });
            Delivery delivery3 = AltaDelivery(DateTime.Now, "Calle Falsa 123", 20, new List<Dish>() { plato6});
            Delivery delivery4 = AltaDelivery(DateTime.Now, "Calle Falsa 123", 20, new List<Dish>() { plato3, plato4 });
            Delivery delivery5 = AltaDelivery(DateTime.Now, "Calle Falsa 123", 20, new List<Dish>() { plato9, plato8 });

            Client cliente1 = AltaCliente("Agustina", "Balsas", "agus@hotmail.com", "agustina1B");
            Client cliente2 = AltaCliente("Ignacio", "Ribas", "ignacio@gmail.com", "ignacio1R");
            Client cliente3 = AltaCliente("Alejo", "Krucheff", "alejo@outlook.com", "alejo13B");
            Client cliente4 = AltaCliente("Anaru", "Martínez", "anaru@gmail.com", "Anaru1");
            Client cliente5 = AltaCliente("Juan", "Rodríguez", "juanr@outlook.com", "juanR13");

            Local local1 = AltaLocal(2, cliente1, new List<Dish>() { plato1, plato2 });
            Local local2 = AltaLocal(4, cliente2, new List<Dish>() { plato6, plato5 });
            Local local3 = AltaLocal(7, cliente3, new List<Dish>() { plato10 });
            Local local4 = AltaLocal(1, cliente4, new List<Dish>() { plato8, plato4 });
            Local local5 = AltaLocal( 3, cliente5, new List<Dish>() { plato9, plato10, plato5 });

            Deliveryman repartidor1 = AltaRepartidor("Agustina", "Balsas", Vehicle.Moto);
            Deliveryman repartidor2 = AltaRepartidor("Juan", "Pérez", Vehicle.Bicicleta);
            Deliveryman repartidor3 = AltaRepartidor("Gonzalo", "Pereira", Vehicle.Pie);
            Deliveryman repartidor4 = AltaRepartidor("Alejandro", "Marella", Vehicle.Bicicleta);
            Deliveryman repartidor5 = AltaRepartidor("Roberto", "Sánchez", Vehicle.Moto);

            Pedido pedido1 = AltaPedido(local1, cliente4);
            Pedido pedido2 = AltaPedido(local4, cliente5);
            Pedido pedido3 = AltaPedido(delivery4, cliente1);
            Pedido pedido4 = AltaPedido(local5, cliente2);
            Pedido pedido5 = AltaPedido(local2, cliente3);
            Pedido pedido6 = AltaPedido(local3, cliente5);
            Pedido pedido7 = AltaPedido(delivery1, cliente4);
            Pedido pedido8 = AltaPedido(delivery3, cliente1);
            Pedido pedido9 = AltaPedido(delivery2, cliente1);
            Pedido pedido10 = AltaPedido(delivery5, cliente3);


        }

        public Pedido AltaPedido(Service service, Client client)
        {
            Pedido pedido = new Pedido(service, client);
            pedidos.Add(pedido);
            return pedido;
            
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
            Delivery delivery = new Delivery(address, distance, dishes);
            services.Add(delivery);
            return delivery;
        }

        public Local AltaLocal(int table, Client cliente, List<Dish> dishes)
        {
            Local local = new Local(table, dishes);

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

        public List<Pedido> Pedidos
        {
            get
            {
                return pedidos;
            }

            set
            {
                pedidos = value;
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