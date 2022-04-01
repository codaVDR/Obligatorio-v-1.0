using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace CLI
{
    public class Menu2

    {
         
        public static string[] menuOptionsArray = new string[]
        {
            "Listar todos los platos.",
            "Listar clientes ordenados por apellido.",
            "Listar servicios entregados por un repartidor en un rango de fechas dado.",
            "Modificar el valor del precio mínimo del plato.",
            "Dar de alta a un mozo.",
            "Salir."
        };

        //Posicion del cursor en la consola
        private static int x;
        private static int y;


        public static void Display2()
        {
            
            bool loop = true;
            int counter = 0;
            ConsoleKeyInfo PressedKey;

            //Oculto cursor
            CursorVisible = false;
            WriteLine("Bienvenido usuario, seleccione una opcion porfavor." + Environment.NewLine);

            //Obteniendo posiciones del cursor
            x = CursorLeft;
            y = CursorTop;

            string strDrawMenu = DrawMenu(menuOptionsArray, counter);

            while (loop)
            {
                //ReadKey cuando recibe true oculta la entrada de teclado que pongo. Mientras no presiono Enter se ejecuta el loop.
                while ((PressedKey = ReadKey(true)).Key != ConsoleKey.Enter)
                {                 
                    switch (PressedKey.Key)
                    {
                        case ConsoleKey.DownArrow:
                            //Validacion para que el cursor no se vaya hacia arriba, toma la cantidad de opciones del array. Pasa a la siguiente iteracion del bucle
                            if (counter == menuOptionsArray.Length - 1) continue;
                            counter++;
                            break;
                        case ConsoleKey.UpArrow:
                            //Validacion para que el cursor no se vaya hacia arriba. Pasa a la siguiente iteracion del bucle
                            if (counter == 0) continue;
                            counter--;
                            break;
                        default:
                            break;
                    }

                    CursorLeft = x;
                    CursorTop = y;
                    Clear(); //provisorio chequear
                    strDrawMenu = DrawMenu(menuOptionsArray, counter);
                }

                switch (counter)
                {
                    case 0:
                        WriteLine("Eligió listar todos los platos.");
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
                        loop = false;
                        ReadKey();
                        break;
                    default:
                        break;
                }

            }

            //Encuentro la opcion seleccionada, la pinto.
            static string DrawMenu(string[] items, int option)
            {
                string selectedOption = string.Empty;
                int highlighted = 0;

                //Clear(); provisorio, chequear

                Array.ForEach(items, element =>
                {
                    if (highlighted == option)
                    {
                        ForegroundColor = ConsoleColor.Green;
                        BackgroundColor = ConsoleColor.DarkRed;
                        WriteLine(element);
                        ForegroundColor = ConsoleColor.White;
                        BackgroundColor = ConsoleColor.Black;
                        selectedOption = element;
                    }
                    else
                    {
                        
                        Write(new string(' ', WindowWidth));
                        CursorLeft = 0;
                        WriteLine(element);                      
                    }

                    highlighted++;
                });    
                return selectedOption;
                //mic check
            }
        }
    }
}


