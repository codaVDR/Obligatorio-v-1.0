using System;


namespace Dominio
{
    public class Deliveryman : Person
    {
        private Vehicle vehicle;
        public Deliveryman(string name, string last_name, Vehicle vehicle) : base (name, last_name)
        {
            Vehicle = vehicle;
        }
        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
    }

    public enum Vehicle
    {
        MOTO,
        BICICLETA,
        PIE
    }
}