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

        public static bool ValidoDatos(string name, string last_name)
        {
            return !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(last_name);
        }

        public override bool Equals(object obj)
        {
            return obj is Deliveryman deliveryman && Name == deliveryman.Name && Last_name == deliveryman.Last_name && vehicle == deliveryman.Vehicle;
        }

        public override string ToString()
        {
            return $"{this.Name} || {this.Last_name} || {this.Vehicle}";
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
