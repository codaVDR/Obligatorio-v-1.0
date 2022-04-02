using System;

namespace Dominio
{
    public class Dish
    {
        //Miembros de la clase
        static public float minimumPrice = 100;
        static public int id = 0;

        //Miembros de la instancia
        private int ID = 0;
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
                //Falta implementar
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
                //Falta implementar
            }
        }

        public Dish (string name, float price)
        {
            this.name = name;
            this.price = price;
            this.ID = id;

            id++;
        }

        //Métodos de clase

        public static void ModificarMinimo (float minimo)
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
