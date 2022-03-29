using System;
using System.Collections.Generic;

namespace Dominio
{
    class Service
    {
        // Clase base de los dos servicios: local y delivery
        public DateTime fecha;
        public List<Dish> dishes;

        public Service ()
        {
            dishes = new List<Dish>();
        }
    }
    
    class Delivery : Service
    {
        // Clase derivadas de la base Service
        private string address;
        private float distance;

        public Delivery (string address, float distance) : base ()
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

        public void CalculateTotal ()
        {
            /*
             * Si la entrega es mediante Delivery se agregan $50 de envío
             * en las distancias menores a 2 km, y va a aumentando $10 por
             * cada kilómetro, hasta un máximo de $100. 
             */
            float total = 0;

            foreach (var dish in dishes)
            {
                total += dish.Price;
            }

            if (distance < 2)
            {
                total += 50;
            } else if (distance >= 2)
            {

            }
        }
    } 

    class Local : Service
    {
        // Clase derivada de la base Service
        private int table;
        private Client guest;
        private float cover;
        
        public Local (int table, Client guest, float cover) : base ()
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