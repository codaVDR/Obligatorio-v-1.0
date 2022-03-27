using System;

namespace Dominio
{
    class Service
    {
        // Clase base de los dos servicios: local y delivery
        DateTime fecha;
    }
    
    class Delivery : Service
    {
        // Clase derivadas de la base Service
        private string address;
        private float distance;

        public Delivery (string address, float distance)
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

    } 

    class Local : Service
    {
        // Clase derivada de la base Service
        private int table;
        private Client guest;
        private float cover;
        
        public Local (int table, Client guest, float cover)
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