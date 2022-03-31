using System;
using CLI;
using Dominio;
using static Validation.Validator;

namespace Manager
{
    class Program
    {
        // Agregarle una lista de platos. Lista platos = vacío

        static void Main(string[] args)
        {
            Console.WriteLine("Tu padre!");

            Console.WriteLine(EsAlfanumerico("cosasas123!"));


            //Esta clase pensaba que fuera la que gestiona todas las demás
            //y desde donde se lanza la aplicación. El punto de entrada, digamos.
        }

    }
}
