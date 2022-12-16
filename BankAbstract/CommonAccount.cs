using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class CommonAccount : Account
    {
        private float overdraftLimit;

        public CommonAccount(float overdraftLimit, string reference, float balance, DateTime creationDate) : base(reference,balance, creationDate)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(float amount)
        {
            if (amount > overdraftLimit) throw new OverdraftLimitHitException();

            if (amount < 0) throw new AmountLowerThanZeroException();
            if (balance < amount) throw new BalanceTooLowException();
            balance -= amount;
        }
    }
}
