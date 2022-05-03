using System;
using Dominio;
using CLI;
using static System.Console;

namespace Manager
{
    class Program
    {
        static Manager manager = new Manager();

        static void Main()
        {
            Setup();
            Run();
        }

        static void Setup()
        {
            foreach (var pedido in manager.Pedidos)
            {
                if (pedido.Service is Delivery)
                {
                    Delivery delivery = (Delivery)pedido.Service;
                    delivery.Deliver();
                }
            }
        }

        static void Run()
        {
            Menu.Display();

            switch (Menu.Selected)
            {
                case 0:
                    Clear();
                    WriteLine("  ~  Lista de platos  ~" + Environment.NewLine);
                    ForegroundColor = ConsoleColor.Cyan;
                    manager.ListarPlatos();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\n\n\n\n───────────────────────────────────────────────────────────────\nPresione Enter para volver, cualquier otra tecla para salir.");
                    ConsoleKeyInfo option0 = ReadKey();
                    if (option0.Key == ConsoleKey.Enter)
                    {
                        Clear();
                        Run();
                    }
                    break;
                case 1:
                    Clear();
                    WriteLine("  ~  Lista de clientes ordenados por su apellido  ~" + Environment.NewLine);
                    ForegroundColor = ConsoleColor.Cyan;
                    manager.ListarClientes();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\n\n\n\n\n───────────────────────────────────────────────────────────────\nPresione Enter para volver, cualquier otra tecla para salir.");
                    ConsoleKeyInfo option1 = ReadKey();
                    if (option1.Key == ConsoleKey.Enter)
                    {
                        Clear();

                        Run();
                    }
                    break;
                case 2:
                    Clear();
                    ForegroundColor = ConsoleColor.Cyan;
                    manager.ListarRepartidores();
                    WriteLine("\nPor favor, ingresar ID de delivery");
                    ForegroundColor = ConsoleColor.Cyan;
                    string deliveryId= ReadLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nPor favor, ingresar año de inicio");
                    ForegroundColor = ConsoleColor.Cyan;
                    string añoInicio = ReadLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nPor favor, ingresar mes de inicio");
                    ForegroundColor = ConsoleColor.Cyan;
                    string mesInicio = ReadLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nPor favor, ingresar dia de inicio");
                    ForegroundColor = ConsoleColor.Cyan;
                    string diaInicio = ReadLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nPor favor, ingresar año final");
                    ForegroundColor = ConsoleColor.Cyan;
                    string añoFinal = ReadLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nPorfavor ingresar mes final");
                    ForegroundColor = ConsoleColor.Cyan;
                    string mesFinal = ReadLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nPorfavor ingresar dia final");
                    ForegroundColor = ConsoleColor.Cyan;
                    string diaFinal = ReadLine();
                    ForegroundColor = ConsoleColor.Green;
                    try
                    {
                        ///NO HAY que hacer tryparse?
                        int repartidorId = Int32.Parse(deliveryId);
                        int añoInicioParse = Int32.Parse(añoInicio);
                        int mesInicioParse = Int32.Parse(mesInicio);
                        int diaInicioParse = Int32.Parse(diaInicio);
                        int añoFinalParse = Int32.Parse(añoFinal);
                        int mesFinalParse = Int32.Parse(mesFinal);
                        int diaFinalParse = Int32.Parse(diaFinal);

                        DateTime fechaInicio = new DateTime(añoInicioParse, mesInicioParse, diaInicioParse);
                        DateTime fechaFinal = new DateTime(añoFinalParse, mesFinalParse, diaFinalParse);

                        manager.ListarDeliveries(fechaInicio, fechaFinal, repartidorId);
                        ReadKey();
                        Clear();
                        Run();

                    }
                    catch (Exception m)
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("\nERROR: Ingreso caracteres invalidos. Presione enter para volver al menu inicial, cualquier otra tecla para salir.");
                        ConsoleKeyInfo option3 = ReadKey();
                        if (option3.Key == ConsoleKey.Enter)
                        {
                            Clear();
                            Run();
                        }
                    }
                    break;
                case 3:
                    Clear();
                    WriteLine("─────────────────────────────────────────────────────" + Environment.NewLine);
                    WriteLine("Porfavor, ingrese un nuevo valor minimo para los platos: " + Environment.NewLine);
                    ForegroundColor = ConsoleColor.Cyan;
                    string inputMinimum = ReadLine();
                    ForegroundColor = ConsoleColor.Green;
                    float newMinimum;
                    bool success = float.TryParse(inputMinimum, out newMinimum);
                    if (success)
                    {
                        Dish.UpdateMinimum(newMinimum);
                        foreach (var dish in manager.Dishes)
                        {
                            if (dish.Price < newMinimum)
                                dish.Price = newMinimum;
                        }
                        WriteLine(Environment.NewLine + "─────────────────────────────────────────────────────");
                        ForegroundColor = ConsoleColor.Cyan;
                        WriteLine($"{Environment.NewLine} El nuevo precio mínimo es » {Dish.minimumPrice} «\n ");
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("Presione Enter para volver, cualquier otra tecla para salir.");
                        ConsoleKeyInfo option2 = ReadKey();

                        if (option2.Key == ConsoleKey.Enter)
                        {
                            Clear();
                            Run();
                        }
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("\nERROR: Ingreso caracteres invalidos. Presione enter para volver al menu inicial, cualquier otra tecla para salir.");
                        ConsoleKeyInfo option2 = ReadKey();
                        if (option2.Key == ConsoleKey.Enter)
                        {
                            Clear();
                            Run();
                        }
                    }
                    break;
                case 4:
                    Clear();
                    WriteLine("  ~  Dar alta a un mozo  ~" + Environment.NewLine);
                    WriteLine("Porfavor, ingrese el nombre del mozo: ");
                    ForegroundColor = ConsoleColor.Cyan;
                    string waiterName = ReadLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Porfavor, ingrese el apellido del mozo: ");
                    ForegroundColor = ConsoleColor.Cyan;
                    string waiterLastName = ReadLine();
                    ForegroundColor = ConsoleColor.Green;
                    if (Waiter.ValidWaiter(waiterName, waiterLastName) == true)
                    {
                        manager.AltaMozo(waiterName, waiterLastName);
                        WriteLine(Environment.NewLine + "─────────────────────────────────────────────────────");
                        WriteLine(Environment.NewLine + "~ Lista de mozos: ~" + Environment.NewLine);
                        ForegroundColor = ConsoleColor.Cyan;
                        manager.ListarWaiters();
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("\n\n\n\n\n───────────────────────────────────────────────────────────────\nPresione Enter para volver, cualquier otra tecla para salir.");
                        ConsoleKeyInfo option3 = ReadKey();
                        if (option3.Key == ConsoleKey.Enter)
                        {
                            Clear();
                            Run();
                        }
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("\nERROR: Ingreso caracteres invalidos.Presione enter para volver al menu inicial, cualquier otra tecla para salir.");
                        ConsoleKeyInfo option3 = ReadKey();
                        if (option3.Key == ConsoleKey.Enter)
                        {
                            Clear();
                            Run();
                        }
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
