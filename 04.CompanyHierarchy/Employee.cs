using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    public class Employee : Person, IEmployee
    {
        public double Salary { get; set; }
        public Departament Departament { get; set; }

        public Employee(
            int id, 
            string firstName, 
            string lastName, 
            double salary,
            Departament departament)
            :base(id, firstName, lastName)
        {
        }
    }
}
