using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestãoFuncionarios
{
    internal class Manager(string name, double baseSalary, string role) : Employee(name, baseSalary, role)
    {
        public override double CalculateSalary()
        {
            double total = BaseSalary;
            total += total * 10 / 100;
            return total;
        }
    }
}
