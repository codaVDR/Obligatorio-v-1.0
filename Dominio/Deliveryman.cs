using System;



namespace Dominio
{
    public class Deliveryman : Person
    {
        public string name;
        public string last_name;
        public Dominio.Enums.TipoVehiculo Tipo { get; set; }


        public Deliveryman(string name, string last_name) : base (name, last_name)
        {
            
            //Acá debería implementarse la asignación de un vehículo para este objeto.
        }
    }
}