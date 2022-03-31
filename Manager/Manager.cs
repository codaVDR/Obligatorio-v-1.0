
using System.Collections.Generic;
using Dominio;

namespace Manager
{
    public class Manager
    {
        private List<Dish> dishes = new List<Dish>();

        public Manager()
        {
            PrecargarDatos();
        }

        public void PrecargarDatos()
        {
            Dish plato1 = AltaPlatos("Sushi", 490);
            Dish plato2 = AltaPlatos("Ñoquis", 600);
            Dish plato3 = AltaPlatos("Pizza", 490);
            Dish plato4 = AltaPlatos("Napolitana", 660);
            Dish plato5 = AltaPlatos("Ensalada", 390);
            Dish plato6 = AltaPlatos("Chivito", 550);
            Dish plato7 = AltaPlatos("Rabas", 900);
            Dish plato8 = AltaPlatos("Sandwich Caliente", 220);
            Dish plato9 = AltaPlatos("Pollo", 450);
            Dish plato10 = AltaPlatos("Hamburguesa", 350);

        }

        public Dish AltaPlatos(string name, float price)
        {
            bool validado = Dish.ValidarDatos(name, price);

            if (validado == false)
                return null;

            Dish plato = new Dish(name, price);

            if (Dishes.Contains(plato))
                plato = null;
            else
                Dishes.Add(plato);

            return plato;
        }

        public List<Dish> Dishes
        {
            get
            {
                return dishes;
            }

            set
            {
                dishes = value;
            }
        }
    }
}