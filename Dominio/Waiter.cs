using System;

namespace Dominio
{
    public class Waiter : Person
    {
        private int wNum;

        public Waiter(string name, string last_name, int wNum) : base (name, last_name)
        {
            WNum = wNum;
        }

        public int WNum { get => wNum; set => wNum = value; } // ¿tiene que ser autoincremental?
    }
}
