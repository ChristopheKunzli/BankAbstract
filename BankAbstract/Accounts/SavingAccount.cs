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

        /// <summary>
        /// Withdraw monye from a savings account
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="AmountLowerThanZeroException"></exception>
        /// <exception cref="BalanceTooLowException"></exception>
        public override void Withdraw(float amount)
        {
            if (amount < 0) throw new AmountLowerThanZeroException();
            if (balance < amount) throw new BalanceTooLowException();
            balance -= amount;
        }

        /// <summary>
        /// Calculate the interest amount and add it to the account if requested
        /// </summary>
        /// <param name="IntegratedInterest"></param>
        /// <returns>the interest amoun</returns>
        public float Interest(bool IntegratedInterest = false)
        {
            float interest = (balance * rateInterest) / (float)100.0;
            if (IntegratedInterest) balance += interest;
            return interest;
        }

        /// <summary>
        /// Show summary of a savingAccount
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $"; Interest rate: {rateInterest}%";
        }
    }
}
