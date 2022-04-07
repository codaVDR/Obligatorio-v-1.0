using System;
using Dominio;
using CLI;
using static System.Console;

namespace Manager
{
    class Program
    {

        static void Main(string[] args)
        {
            int option = Menu.Display();
            WriteLine(option);
            //bool loop = true;
            
                switch (option)
                {
                    case 0:
                        WriteLine("Plato 1");
                        WriteLine("Plato 1");
                        WriteLine("Plato 1");
                        WriteLine("Plato 1");
                        ReadKey();


                    break;
                    case 1:
                        WriteLine("Eligió listar clientes ordenados por apellido.");
                        break;
                    case 2:
                        WriteLine("Eligió listar servicios entregados por un repartidor en un rango de fechas dado.");
                        break;
                    case 3:
                        WriteLine("Eligió modificar el valor del precio mínimo del plato.");
                        break;
                    case 4:
                        WriteLine("Eligió dar de alta a un mozo.");
                        break;
                    case 5:
                        WriteLine("Eligió salir, hasta luego!");
                        //loop = false;
                        ReadKey();
                        break;
                    default:
                        break;


                }
            
        






        Client client1 = new Client("Alfonso", "Piedrabuena", "correofalso@gmail.com", "12345");

            
            

            Manager manager = new Manager();

            Console.WriteLine(manager.Dishes);
            
            Local local = new Local(DateTime.Now, 1);

            local.AddGuest(client1);
            local.AddDish(manager.Dishes[1]);
            local.AddDish(manager.Dishes[2]);

            foreach (var dish in local.Dishes)
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
