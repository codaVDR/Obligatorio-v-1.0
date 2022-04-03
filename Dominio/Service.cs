using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Service
    {
        // Clase base de los dos servicios: local y delivery
        private DateTime date;
        private List<Dish> dishes;

        public DateTime Date { get => date; set => date = value; }
        public List<Dish> Dishes { get => dishes; set => dishes = value; }

        public Service (DateTime date)
        {
            this.Dishes = new List<Dish>();
            this.Date = date;
        }

        public void AddDish (Dish dish)
        {
            Dishes.Add(dish);
        }
    }
    
    public class Delivery : Service
    {
        // Atributos de la clase derivada de la base
        private string address;
        private float distance;

        public Delivery (DateTime date, string address, float distance) : base (date)
        {
            
            this.address = address;
            this.distance = distance;
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public float Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }

        public float CalculateTotal ()
        {
             /*
             * Si la entrega es mediante Delivery se agregan $50 de envío
             * en las distancias menores a 2 km, y va a aumentando $10 por
             * cada kilómetro, hasta un máximo de $100. 
             */
            float total = 50;
            float extra = 0;

            foreach (var dish in Dishes)
            {
                total += dish.Price;
            }

            if (distance >= 2)
            {
                for (int i = 0; i < distance - 2; i++)
                {
                    extra += 10;
                    extra = Math.Min(extra, 100);
                }
            }
            return total + extra;
        }
    } 

    public class Local : Service
    {
        // Clase derivada de la base Service
        private int table;
        private List<Client> guests;
        private static float cover = 100;
        
        public Local (DateTime date, int table) : base (date)
        {
            this.table = table;
            this.guests = new List<Client> ();
        }
        public int Table
        {
            get
            {
                return table;
            }

            set
            {
                table = value;
            }
        } 

        public float CalculateTotal ()
        {
            float total = 0;
            foreach (var guest in guests)
            {
                total += cover;
            }
            foreach (var dish in Dishes)
            {
                total += dish.Price;
            }
            float tip = (float)(total * 0.1);

            return total + tip;
        }

        public void AddGuest (Client guest)
        {
            guests.Add(guest);
        }

        public List<Client> Guests
        {
            get
            {
                return guests;
            }

            set
            {
                guests = value;
            }
        }

        public float Cover
        {
            get
            {
                return cover;
            }
            set
            {
                cover = value;
            }
        }

    }
}