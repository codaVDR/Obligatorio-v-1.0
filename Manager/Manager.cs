
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

        public void PrecargarDishes ()
        {
            Dish plato1 = AltaPlato("Sushi", 490);
            Dish plato2 = AltaPlato("Ñoquis", 600);
            Dish plato3 = AltaPlato("Pizza", 490);
            Dish plato4 = AltaPlato("Napolitana", 660);
            Dish plato5 = AltaPlato("Ensalada", 390);
            Dish plato6 = AltaPlato("Chivito", 550);
            Dish plato7 = AltaPlato("Rabas", 900);
            Dish plato8 = AltaPlato("Sandwich Caliente", 220);
            Dish plato9 = AltaPlato("Pollo", 450);
            Dish plato10 = AltaPlato("Hamburguesa", 350);
        }

        public void PrecargarClients ()
        {
            //Falta implementar
        }

        public void PrecargarDatos()
        {
            PrecargarDishes();
            PrecargarClients();
        }

        public Client AltaCliente (string name, string last_name, string email, string password)
        {
            return null;
        }

        public Waiter AltaMozo (string name, string last_name, int wnum)
        {
            return null;
        }

        public Deliveryman AltaRepartidor (string name, string last_name)
        {
            return null;
        }

        public Service AltaServcio ()
        {
            return null;
        }

        public Dish AltaPlato(string name, float price)
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