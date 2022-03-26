using System;

namespace Dominio
{
    public class Dish
    {
        static public int id = 0;
        private int ID = 0;
        private string name;
        private float price;     

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
            //Implementar
        }
    }


}
