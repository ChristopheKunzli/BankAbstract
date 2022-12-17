using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public abstract class BankEmployee : Person
    {
        protected int department;

        public int Department { get { return department; } }

        public BankEmployee(string name, string firstName, DateTime birthDate, int department) : base(name, firstName, birthDate) 
        { 
            this.department = department;
        }

        public abstract double GetSalary();
    }
}
