using System;
using Dominio;
using static Validation.Validator;
using static Manager.Manager;

namespace Manager
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Tu padre!");

            Console.WriteLine(EsAlfanumerico("cosasas123"));

            Client client1 = new Client("Ignacio", "Ribas", "iribastrillo@gmail.com", "12345");
            Client client2 = new Client("Christopher", "Pernales", "pernaleschristopher@gmail.com", "12345");

            Manager manager = new Manager();

            
            Local local = new Local(DateTime.Now, 1);

            local.AddGuest(client1);
            local.AddGuest(client2);
            local.AddDish(manager.Dishes[1]);
            local.AddDish(manager.Dishes[2]);

            foreach (var dish in local.dishes)
            {
                Console.WriteLine(dish);
            }

            foreach (var guest in local.Guests)
            {
                Console.WriteLine(guest);
            }

            Console.WriteLine(local.CalculateTotal());

        }

    }
}
