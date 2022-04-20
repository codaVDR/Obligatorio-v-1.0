using System;

namespace Dominio
{
    public class Dish
    {
        static public float minimumPrice = 100;
        static public int n = 0;

        private int iD = 0;
        private string name;
        private float price;     

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int ID { get => iD; set => iD = value; }

        public Dish (string name, float price)
        {
            Name = name;
            Price = price;
            ID = n;

            n++;
        }
        public static void UpdateMinimum (float minimo)
        {
            minimumPrice = minimo;
        }

        public static bool ValidarDatos(string nombre, float precio)
        {
            return !string.IsNullOrWhiteSpace(nombre)
                && precio > minimumPrice;
        }

        public override bool Equals(object obj)
        {
            return obj is Dish plato && name == plato.name && price == plato.price && ID == plato.ID;
        }

        public override string ToString()
        {
            return $"{this.name} || {this.price}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
