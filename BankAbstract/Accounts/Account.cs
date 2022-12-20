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

        /// <summary>
        /// Withdraws money from an account
        /// </summary>
        /// <param name="amount"></param>
        public abstract void Withdraw(float amount);        

        /// <summary>
        /// Deposit money in an account
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="AmountLowerThanZeroException"></exception>
        public void Deposit(float amount)
        {
            if (amount < 0) throw new AmountLowerThanZeroException();
            balance += amount;
        }

        /// <summary>
        /// Transfer moneey from an account to another
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="acc"></param>
        /// <exception cref="AccountNotExistingException"></exception>
        public void Transfer(float amount, Account acc)
        {
            if (acc == null) throw new AccountNotExistingException();
            Withdraw(amount);
            acc.Deposit(amount);
        }

        /// <summary>
        /// Show a generic summary of an account
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Reference: {reference}; Current Balance: ${balance}; Date of creation: {creationDate}";
        }
    }
}
