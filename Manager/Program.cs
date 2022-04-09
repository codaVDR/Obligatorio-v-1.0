using System;
using Dominio;
using CLI;
using static System.Console;

namespace Manager
{
    class Program
    {

        static void Main()
        {
            Menu.Display();

            Client client1 = new Client("Alfonso", "Piedrabuena", "correofalso@gmail.com", "12345");
            Manager manager = new Manager();
            Local local = new Local(DateTime.Now, 1);
            local.AddGuest(client1);
            local.AddDish(manager.Dishes[1]);
            local.AddDish(manager.Dishes[2]);
            switch (Menu.Selected)
            {
                    case 0:
                        Clear();
                        WriteLine("  ~  Lista de platos  ~" + Environment.NewLine);
                        manager.ListarPlatos();
                        

                        WriteLine("\n\n\n\n\n───────────────────────────────────────────────────────────────\nPresione Enter para volver, cualquier otra tecla para salir.");
                        ConsoleKeyInfo option0 = ReadKey();
                        if (option0.Key == ConsoleKey.Enter)
                        {
                            Clear();
                            Main();
                        }
                    break;
                    case 1:
                    Clear();
                    WriteLine("  ~  Lista de clientes ordenados por su apellido  ~" + Environment.NewLine);
                    manager.ListarClientes();
                    WriteLine("\n\n\n\n\n───────────────────────────────────────────────────────────────\nPresione Enter para volver, cualquier otra tecla para salir.");

                    ConsoleKeyInfo option1 = ReadKey();
                    if (option1.Key == ConsoleKey.Enter)
                    {
                        Clear();

                        Main();
                    }
                    break;
                    case 2:
                        WriteLine("Eligió listar servicios entregados por un repartidor en un rango de fechas dado.");
                        break;
                    case 3:
                        Clear();
                        WriteLine("─────────────────────────────────────────────────────" + Environment.NewLine);
                        WriteLine("Porfavor, ingrese un nuevo valor minimo para los platos: " + Environment.NewLine);
                        string inputMinimum = ReadLine();
                        float newMinimum;
                        bool success = float.TryParse(inputMinimum, out newMinimum);
                        if (success)
                        {
                            Dish.UpdateMinimum(newMinimum);
                            WriteLine(Environment.NewLine + "─────────────────────────────────────────────────────");
                            WriteLine($"{Environment.NewLine} El nuevo valor mínimo es: {Dish.minimumPrice} \n Presione Enter para volver, cualquier otra tecla para salir. ");
                            
                        }  
                        ConsoleKeyInfo option3 = ReadKey();
                        if (option3.Key == ConsoleKey.Enter)
                        {
                            Clear();

                            Main();
                        }
                        break;
                    case 4:
                    Clear();
                    WriteLine("  ~  Dar alta a un mozo  ~" + Environment.NewLine);
                    //manager.AltaMozo();
                    WriteLine("Porfavor, ingrese el nombre del mozo: ");
                    string waiterName = ReadLine();
                    WriteLine("Porfavor, ingrese el apellido del mozo: ");
                    string waiterLastName = ReadLine();
                    WriteLine("Porfavor, ingrese el numero de mozo: ");
                    string waiterNumberInput = ReadLine();
                    int waiterNumber;
                    Int32.TryParse(waiterNumberInput, out waiterNumber);


                    //manager.AltaMozo(waiterName, waiterLastName, waiterNumber);
                    //Falta mejorar, no pude con la funcion en manager. Intente varias cosas pero no se porque no esta funcionando je.

                    WriteLine("\n\n\n\n\n───────────────────────────────────────────────────────────────\nPresione Enter para volver, cualquier otra tecla para salir.");
                    ConsoleKeyInfo option4 = ReadKey();
                    if (option4.Key == ConsoleKey.Enter)
                    {
                        Clear();
                        Main();
                    }
                    break;
                    case 5:
                        ForegroundColor = ConsoleColor.Red; WriteLine(Environment.NewLine + "Eligió salir, hasta luego!");
                        //loop = false;
                        ReadKey();
                        break;
                    default:
                        break;


            }
        }
    }
}
