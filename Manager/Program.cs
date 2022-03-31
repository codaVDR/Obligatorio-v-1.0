using System;
using CLI;
using Dominio;
using static Validation.Validator;

namespace Manager
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Tu padre!");

            Console.WriteLine(EsAlfanumerico("cosasas123!"));

            Local local = new Local(DateTime.Now, 1);
        }

    }
}
