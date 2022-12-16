using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class AmountLowerThanZeroException : Exception
    {
        public AmountLowerThanZeroException() :base("The amount given cannot be below zero") { }
    }
}
