using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class SalaryInformationMissingException : Exception
    {
        public SalaryInformationMissingException() : base ("Some salary informations are missing") { }
    }
}
