using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Service
    {
        // Clase base de los dos servicios: local y delivery
        public DateTime date;
        public List<Dish> dishes;

        public Service (DateTime date)
        {
            this.dishes = new List<Dish>();
            this.date = date;
        }

        public void AddDish (Dish dish)
        {
            dishes.Add(dish);
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

            foreach (var dish in dishes)
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
        private Client guest;
        private float cover;
        
        public Local (DateTime date, int table, Client guest, float cover) : base (date)
        {
            this.table = table;
            this.guest = guest;
            this.cover = cover;
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

        public Client Guest
        {
            get
            {
                return guest;
            }

            set
            {
                guest = value;
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