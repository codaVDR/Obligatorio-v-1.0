using System;
using static Validation.Validator;


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

        public static bool isValid (string name, string last_name, string email, string password)
        {
            bool isValidName = string.IsNullOrEmpty (name) && SinNumeros (name);
            bool isValidLastName = string.IsNullOrEmpty(last_name) && SinNumeros(last_name);
            bool isValidEmail = EsValido(email);
            bool isValidPassword = EsSegura(password);

            bool isValid = isValidName && isValidLastName && isValidEmail && isValidPassword;
            return isValid;
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
