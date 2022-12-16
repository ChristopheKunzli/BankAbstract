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

        public override void Withdraw(float amount)
        {
            if (amount < 0) throw new AmountLowerThanZeroException();
            if (balance < amount) throw new BalanceTooLowException();
            balance -= amount;
        }

        public float Interest(bool IntegratedInterest)
        {
            float interest = (balance * rateInterest) / (float)100.0;
            if (IntegratedInterest) balance += interest;
            return interest;
        }
    }
}
