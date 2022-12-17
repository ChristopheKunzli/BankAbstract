using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public abstract class Person
    {
        protected string name;
        protected string firstName;
        DateTime birthDate;

        public string Name { get { return name; } }
        public string FirstName { get { return firstName;} }
        public DateTime DateTimeBirthDate { get { return birthDate;} }

        /// <summary>
        /// Basic constructor for a person object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        /// <param name="birthDate"></param>
        public Person (string name, string firstName, DateTime birthDate)
        {
            this.name = name;
            this.firstName = firstName;
            this.birthDate = birthDate;
        }
    }
}
