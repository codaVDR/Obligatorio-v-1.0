using System;
using Dominio;
using static Validation.Validator;
using static Manager.Manager;

namespace Manager
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Tu padre!");

            Console.WriteLine(EsAlfanumerico("cosasas123!"));

            Manager manager = new Manager();

            Console.WriteLine(manager.Dishes);

            Local local = new Local(DateTime.Now, 1);
        }

    }
}
