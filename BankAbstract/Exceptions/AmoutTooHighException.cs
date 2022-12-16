using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class AmoutTooHighException : Exception
    {
        public AmoutTooHighException() : base("The amount given is too high") { }
    }
}
