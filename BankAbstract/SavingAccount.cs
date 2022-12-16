using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class SavingAccount : Account
    {
        private float rateInterest;

        public SavingAccount(float rateInterest, string reference, float balance, DateTime creationDate) : base(reference,balance,creationDate)
        {
            this.rateInterest = rateInterest;
        }

        public float Interest(bool IntegratedInterest)
        {
            throw new NotImplementedException();
        }
    }
}
