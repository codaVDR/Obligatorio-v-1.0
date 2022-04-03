using System;
using static Validation.Validator;


namespace Dominio
{
    public class Client : Person
    {
        private string email;
        private string password;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public Client (string name, string last_name, string email, string password) : base (name, last_name)
        {
            this.Email = email;
            this.Password = password;
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
            return $"{Last_name} || {Name} || {Email}";
        }

        public override bool Equals(object obj)
        {
             return obj is Client client && Name == client.Name && Last_name == client.Email;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
