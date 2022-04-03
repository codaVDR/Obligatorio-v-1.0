﻿using System;
using Dominio;

namespace Manager
{
    class Program
    {

        static void Main(string[] args)
        {
            CLI.Menu.Display();

            Client client1 = new Client("Alfonso", "Piedrabuena", "correofalso@gmail.com", "12345");

            Manager manager = new Manager();

            
            Local local = new Local(DateTime.Now, 1);

            local.AddGuest(client1);
            local.AddDish(manager.Dishes[1]);
            local.AddDish(manager.Dishes[2]);

            foreach (var dish in local.Dishes)
            {
                Console.WriteLine(dish);
            }

            foreach (var guest in local.Guests)
            {
                Console.WriteLine(guest);
            }

            Console.WriteLine(local.CalculateTotal());


        }

    }
}
