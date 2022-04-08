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
                        manager.ListarPlatos();
                        ConsoleKeyInfo option0 = ReadKey();
                        if (option0.Key == ConsoleKey.Enter)
                        {
                            Clear();
                            Main();
                        }
                    break;
                    case 1:
                    Clear();
                    manager.ListarClientes();
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
                        WriteLine("Ingresa el nuevo valor mínimo para los platos");
                    string inputMinimum = ReadLine();
                        float newMinimum;
                        bool success = float.TryParse(inputMinimum, out newMinimum);
                        if (success)
                        {
                            Dish.UpdateMinimum(newMinimum);
                            WriteLine("─────────────────────────────────────────────────────" + Environment.NewLine);
                            WriteLine($"El nuevo valor mínimo es: {Dish.minimumPrice} || ");
                            WriteLine("─────────────────────────────────────────────────────" + Environment.NewLine);
                        }  
                        ConsoleKeyInfo option3 = ReadKey();
                        if (option3.Key == ConsoleKey.Enter)
                        {
                            Clear();

                            Main();
                        }
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
        }
    }
}
