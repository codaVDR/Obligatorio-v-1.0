using System;
using CLI;
using Dominio;
using static Validation.Validator;

namespace Manager
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Tu padre!");

<<<<<<< HEAD
            Console.WriteLine(EsAlfanumerico("cosasas123!"));




            Console.WriteLine(EsAlfanumerico("cosasas123"));
=======
            Console.WriteLine(EsSegura("cosasas123"));
>>>>>>> 7105e6140871ed18d88e6ab6f11a458285223a23

            Client client1 = new Client("Alfonso", "Piedrabuena", "correofalso@gmail.com", "12345");

            Manager manager = new Manager();

            
            Local local = new Local(DateTime.Now, 1);

            local.AddGuest(client1);
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
