using System;
using static System.Console;
using Clases;

namespace Test_Menu
{
    class Menu
    {
        static void Main(string[] args)
        {
            //Probablemente esto se puede hacer de mejor manera, fue la manera que encontre de hacerlo pero bueno si saben de otro modo se cambia 0 estres.
            //Espero que se entienda todo.
            ForegroundColor = ConsoleColor.Green; 
            WriteLine(" ┌──────────────────────────────────────────────────────────────────────┐");
            WriteLine(" │                                Menú                                  │");
            WriteLine(" │                                                                      │");
            WriteLine(" │  - Listar todos los platos                            [1]            │");
            WriteLine(" │  - Listar clientes ordenado por apellido              [2]            │");
            WriteLine(" │  - Listar servicios entregados por un repartidor                     │");
            WriteLine(" │      en un rango de fechas dado.                      [3]            │");
            WriteLine(" │  - Modificar el valor del precio mínimo del plato.    [4]            │");
            WriteLine(" │  - Dar de alta a un mozo                              [5]            │");
            WriteLine(" │                                                                      │");
            WriteLine(" │                                                                      │");
            WriteLine(" │                                                                      │");
            WriteLine(" │                                                     - [6]Salir       │");
            WriteLine(" └──────────────────────────────────────────────────────────────────────┘");
       
            bool exit = false;
            while (!exit)
            {           
                try
                {
                    int option = Convert.ToInt32(ReadLine());
                    switch (option)
                    {
                        case 1:
                            WriteLine("Elegiste la opcion numero 1");
                            break;
                        case 2:
                            WriteLine("Elegiste la opcion numero 2");
                            break;
                        case 3:
                            WriteLine("Elegiste la opcion numero 3");
                            break;
                        case 4:
                            WriteLine("Elegiste la opcion numero 4");
                            break;
                        case 5:
                            WriteLine("Elegiste la opcion numero 5");
                            break;                    
                        case 6:
                            WriteLine("Elegiste salir del programa");
                            exit = true;
                            break;
                        default:
                            WriteLine("Por favor, ingrese solo números de una cifra del 1 al 7");
                            break;
                    }
                }catch (FormatException) //Format exception esta buenisimo, se podria darle un nombre y que tire el error en ingles, decidi tirar el mismo error en los 2 casos. Dejo el codigo comentado igual 
                {
                    //WriteLine(error.Message); Error es una variable que creariamos poniendola despues de FormatException. Es decir arriba quedaria (FormatException error) y aca tiras el .Message de esa clase.
                    WriteLine("Por favor, ingrese solo números de una cifra del 1 al 7");
                }             
            }
            ReadLine();   

        }
    }
}





