using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public abstract class Account
    {
        protected string reference;
        protected float balance;
        protected DateTime creationDate;

        public string Reference { get { return reference; } }
        public float Balance { get { return balance; } }
        public DateTime CreationDate { get { return creationDate; } }

        public Account(string reference, float balance, DateTime creationDate)
        { 
            this.reference = reference;
            this.balance = balance;
            this.creationDate = creationDate;
        }

        public void Withdraw(float amount)
        {
            if (amount < 0) throw new AmountLowerThanZeroException();
            if (balance < amount) throw new BalanceTooLowException();
            balance -= amount;
        }

        public void Deposit(float amount)
        {
            if (amount < 0) throw new AmountLowerThanZeroException();
            balance += amount;
        }

        public void Transfer(float amount, Account acc)
        { 
            acc.Deposit(amount);
        }

        public override string ToString()
        {
            return "ref: " + reference + ";balance: " + balance + ";creationDate: " + creationDate.ToString();
        }
    }
}
