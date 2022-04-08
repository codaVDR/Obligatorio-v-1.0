﻿using System;
using static System.Console;

namespace CLI
{
    public class Menu
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

        public static int Selected { get; set; } = 0;

        public static void Display()
        {
            bool loop = true;

            ConsoleKeyInfo PressedKey;

            //Oculto cursor
            CursorVisible = false;
            WriteLine("Bienvenido usuario, seleccione una opción, por favor." + Environment.NewLine);
            //Obteniendo posiciones del cursor
            x = CursorLeft;
            y = CursorTop;

            DrawMenu(menuOptionsArray, Selected);

                //ReadKey cuando recibe true oculta la entrada de teclado que pongo. Mientras no presiono Enter se ejecuta el loop.
            while ((PressedKey = ReadKey(true)).Key != ConsoleKey.Enter)
            {
                switch (PressedKey.Key)
                {
                    case ConsoleKey.DownArrow:
                        //Validacion para que el cursor no se vaya hacia arriba, toma la cantidad de opciones del array. Pasa a la siguiente iteracion del bucle
                        if (Selected == menuOptionsArray.Length - 1) continue;
                            Selected++;
                            break;
                    case ConsoleKey.UpArrow:
                        //Validacion para que el cursor no se vaya hacia arriba. Pasa a la siguiente iteracion del bucle
                        if (Selected == 0) continue;
                        Selected--;
                        break;
                    default:
                        break;
                }
                CursorLeft = x;
                CursorTop = y;
                Clear(); //provisorio chequear
                DrawMenu(menuOptionsArray, Selected);
            }
        }
        //Encuentro la opcion seleccionada, la pinto.
        private static void DrawMenu(string[] items, int option)
        {
            string selectedOption = string.Empty;
            int highlighted = 0;

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
        }
    }
}