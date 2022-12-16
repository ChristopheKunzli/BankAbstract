using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class BalanceTooLowException : Exception
    {
        public BalanceTooLowException() : base("Balance is too low") { }
    }
}
