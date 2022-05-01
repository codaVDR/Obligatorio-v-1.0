using System;
using static Validation.Validator;


namespace Dominio
{
    public class Client
    {
        private static int n = 0;

        private int iD;
        private string name;
        private string lastName;

        private string email;
        private string password;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public Client (string name, string lastName, string email, string password)
        {
            this.ID = n;

            this.name = name;
            this.lastName = lastName;
            this.Email = email;
            this.Password = password;

            n++;
        }

        public static int CompareByLastName (Client client_one, Client client_two)
        {
            return String.Compare(client_one.LastName, client_two.LastName);
        }

        public static bool IsValid (string name, string last_name, string email, string password)
        {
            bool isValidName = !string.IsNullOrEmpty(name) && SinNumeros(name);
            bool isValidLastName = !string.IsNullOrEmpty(last_name) && SinNumeros(last_name);
            bool isValidEmail = EsValido(email);
            bool isValidPassword = EsSegura(password);

            bool isValid = isValidName && isValidLastName && isValidEmail && isValidPassword;
            return isValid;
        }

        public override string ToString()
        {
            return $"{LastName} || {Name} || {Email}";
        }

        public override bool Equals(object obj)
        {
             return obj is Client client && Name == client.Name && LastName == client.LastName && Email == client.Email;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
