using System;
using static Validation.Validator;


namespace Dominio
{
    public class Client : Person
    {
        public string email;
        public string password;

        public Client (string name, string last_name, string email, string password) : base (name, last_name)
        {
            this.email = email;
            this.password = password;
        }

        public static bool isValid (string name, string last_name, string email, string password)
        {
            bool isValidName = !string.IsNullOrEmpty (name) && SinNumeros (name);
            bool isValidLastName = !string.IsNullOrEmpty(last_name) && SinNumeros(last_name);
            bool isValidEmail = EsValido(email);
            bool isValidPassword = EsSegura(password);

            bool isValid = isValidName && isValidLastName && isValidEmail && isValidPassword;
            return isValid;
        }

        public override string ToString()
        {
            return $"{Last_name} || {Name} || {email}";
        }

        public override bool Equals(object obj)
        {
             return obj is Client client && Name == client.Name && Last_name == client.email;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
