using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Employee
    {
        private static int n = 0;

        private int iD;
        private string name;
        private string lastName;

        public Employee(string name, string lastName)
        {
            ID = n;
            Name = name;
            LastName = lastName;

            n++;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
