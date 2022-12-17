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

        /// <summary>
        /// Base Constructor for any type of bank employee
        /// </summary>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        /// <param name="birthDate"></param>
        /// <param name="department"></param>
        public BankEmployee(string name, string firstName, DateTime birthDate, int department) : base(name, firstName, birthDate) 
        { 
            this.department = department;
        }

        /// <summary>
        /// Calculates the salary of an employee
        /// </summary>
        /// <returns>the salary</returns>
        public abstract double? GetSalary();
    }
}
