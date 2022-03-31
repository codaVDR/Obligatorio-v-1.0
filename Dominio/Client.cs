using System;


namespace Dominio
{
    public class Client
    {
        public int id = 0; //autogenerado: falta implementar
        public string name;
        public string last_name;
        public string email;
        public string password;

        public Client (string name, string last_name, string email, string password)
        {
            this.name = name;
            this.last_name = last_name;
            this.email = email;
            this.password = password;
            // Falta implementar id autogenerado.
        }

        public override string ToString()
        {
            return $"{last_name} || {name} || {email}";
        }

        public override bool Equals(object obj)
        {
             return obj is Client client && name == client.name && last_name == client.email;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
