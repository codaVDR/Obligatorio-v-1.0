using System;
<<<<<<< HEAD
using CLI;
=======
>>>>>>> c12911b59a3f25ec08988aace350418a0cd440ee
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
<<<<<<< .merge_file_a19380
            Menu2.Display2();
=======

            Console.WriteLine(EsAlfanumerico("cosasas123!"));


>>>>>>> .merge_file_a19220
            //Esta clase pensaba que fuera la que gestiona todas las demás
            //y desde donde se lanza la aplicación. El punto de entrada, digamos.
=======

            Console.WriteLine(EsAlfanumerico("cosasas123"));

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

>>>>>>> c12911b59a3f25ec08988aace350418a0cd440ee
        }

    }
}
