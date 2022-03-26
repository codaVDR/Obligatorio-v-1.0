using System;

namespace Dominio
{
    public class Dish
    {
        public int id = 0;
        public string name;
        public float price;     

        public Dish (string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        //Métodos de clase

        public static void ModificarMinimo (float minimo)
        {
            //Implementar
        }
    }


}
