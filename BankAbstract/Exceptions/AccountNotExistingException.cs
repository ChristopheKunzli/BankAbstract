using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class AccountNotExistingException : Exception
    {
        public AccountNotExistingException() : base("Account not found") { }
    }
}
