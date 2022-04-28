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

        public static bool ValidoRepartidor (string name, string last_name)
        {
            return !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(last_name);
        }

        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
        public override string ToString()
        {
            return $"{Last_name} || {Name} || {Vehicle}";
        }

        public override bool Equals(object obj)
        {
            return obj is Deliveryman repartidor && Name == repartidor.Name && Last_name == repartidor.Last_name && vehicle == repartidor.vehicle;
        }
    }

    public enum Vehicle
    {
        Moto,
        Bicicleta,
        Pie
    }
}