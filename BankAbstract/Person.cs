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
    }
}
