using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestãoFuncionarios
{
    abstract class Employee
    {
        protected string Name { get; set; }
        protected double BaseSalary { get; set; }
        protected string Role { get; set; }

        public Employee(string name, double baseSalary, string role) {
            Name = name;
            BaseSalary = baseSalary;
            Role = role;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", $" + CalculateSalary() + ", Role: " + Role;
        }

        abstract public double CalculateSalary();
    }
}
