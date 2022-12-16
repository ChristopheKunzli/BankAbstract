using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class OverdraftLimitHitException : Exception
    {
        public OverdraftLimitHitException() : base ("Amount is higher than your overdraft limit") { }
    }
}
