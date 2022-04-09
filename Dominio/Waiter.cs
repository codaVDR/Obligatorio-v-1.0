using System;
using static Validation.Validator;


namespace Dominio
{
    public class Waiter : Person
    {
        private int wNum = 0;

        static public int num = 0;


        public Waiter(string name, string last_name) : base (name, last_name)
        {
            WNum = num;
            num++;
        }

        public int WNum { get => wNum; set => wNum = value; }

        public static bool ValidWaiter(string name, string last_name)
        {
            return !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(last_name) && SinNumeros(name) && SinNumeros(last_name);
        }

        public override string ToString()
        {
            return $"{Last_name} || {Name} || {WNum}";
        }

        public override bool Equals(object obj)
        {
            return obj is Waiter waiter && Name == waiter.Name && Last_name == waiter.Last_name && WNum == waiter.WNum;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
