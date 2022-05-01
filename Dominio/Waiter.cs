using System;
using static Validation.Validator;


namespace Dominio
{
    public class Waiter : Employee
    {
        private int wNum = 0;

        static public int num = 0;


        public Waiter(string name, string lastName) : base (name, lastName)
        {
            WNum = num;
            num++;
        }

        public int WNum { get => wNum; set => wNum = value; }

        public static bool ValidWaiter(string name, string last_name)
        {
            return !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(last_name) && EsTexto(name) && EsTexto(last_name);
        }

        public override string ToString()
        {
            return $"{LastName} || {Name} || {WNum}";
        }

        public override bool Equals(object obj)
        {
            return obj is Waiter waiter && Name == waiter.Name && LastName == waiter.LastName && WNum == waiter.WNum;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
