using System;
using System.Collections.Generic;

namespace Dominio
{
    public abstract class Service
    {
        protected List<Dish> dishes;

        public List<Dish> Dishes { get => dishes; set => dishes = value; }

        public Service (List<Dish> dishes)
        {
            this.dishes = dishes;
        }

        public void AddDish (Dish dish)
        {
            Dishes.Add(dish);
        }
    }
    
    public class Delivery : Service
    {
        private string address;
        private float distance;
        private Deliveryman deliveryman;


        public DateTime Delivered { get; set; }
        public void Deliver()
        {
            Delivered = new DateTime(2022, 7, 1, 7, 0, 0);
        }

        public Delivery (string address, float distance, Deliveryman deliveryman, List<Dish> dishes) : base ( dishes)
        {
            this.address = address;
            this.distance = distance;
            this.deliveryman = deliveryman;
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

        public Deliveryman Deliveryman { get => deliveryman; set => deliveryman = value; }

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
        public override string ToString()
        {
            return $"{address} || {distance}";
        }
    } 

    public class Local : Service
    {
        private int table;
        private List<Client> guests;
        private static float cover = 100;
        

        public Local (int table, List<Dish> dishes) : base (dishes)
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

        public override string ToString()
        {
            return $"{table} || {guests} || {cover}";
        }
    }
}