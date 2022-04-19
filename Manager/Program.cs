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

            foreach (var service in manager.Services)
            {
                Delivery delivery = (Delivery)service;
                delivery.Deliver();
            }

            // local.AddDish(manager.Dishes[1]);
            // local.AddDish(manager.Dishes[2]);
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
                        Clear();
                        WriteLine("Porfavor ingresar año de inicio");
                        string añoInicio = ReadLine();
                        WriteLine("Porfavor ingresar mes de inicio");
                        string mesInicio = ReadLine();
                        WriteLine("Porfavor ingresar dia de inicio");
                        string diaInicio = ReadLine();
                        WriteLine("Porfavor ingresar año final");
                        string añoFinal = ReadLine();
                        WriteLine("Porfavor ingresar mes final");
                        string mesFinal = ReadLine();
                        WriteLine("Porfavor ingresar dia final");
                        string diaFinal = ReadLine();

                        int añoInicioParse = Int32.Parse(añoInicio);
                        int mesInicioParse = Int32.Parse(mesInicio);
                        int diaInicioParse = Int32.Parse(diaInicio);
                        int añoFinalParse = Int32.Parse(añoFinal);
                        int mesFinalParse = Int32.Parse(mesFinal);
                        int diaFinalParse = Int32.Parse(diaFinal);

                        DateTime fechaInicio = new DateTime(añoInicioParse, mesInicioParse, diaInicioParse);
                        DateTime fechaFinal = new DateTime(añoFinalParse, mesFinalParse, diaFinalParse);

                        manager.ListarDeliveries(fechaInicio, fechaFinal);
                        ReadKey();


                        Clear();
                        Main();

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

                    manager.AltaMozo(waiterName, waiterLastName);

                    WriteLine(Environment.NewLine + "─────────────────────────────────────────────────────");
                    WriteLine(Environment.NewLine + "~ Lista de mozos: ~" + Environment.NewLine);
                    manager.ListarWaiters();



                    
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
                        ForegroundColor = ConsoleColor.Red; 
                        WriteLine(Environment.NewLine + "Eligió salir, hasta luego!");
                        ReadKey();
                        break;
                    default:
                        break;


            }
        }
    }
}
