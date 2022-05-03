using System;

namespace Dominio
{
    public class Deliveryman : Employee
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
            return $"{ID} ||{LastName} || {Name} || {Vehicle}";
        }

        public override bool Equals(object obj)
        {
            return obj is Deliveryman repartidor && Name == repartidor.Name && LastName == repartidor.LastName && vehicle == repartidor.vehicle;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public enum Vehicle
    {
        Moto,
        Bicicleta,
        Pie
    }
}