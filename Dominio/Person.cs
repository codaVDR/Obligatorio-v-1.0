using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Person
    {
        private static int n = 0;

        private int iD;
        private string name;
        private string last_name;

        public Person(string name, string last_name)
        {
            ID = n;
            Name = name;
            Last_name = last_name;

            n++;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
    }
}
