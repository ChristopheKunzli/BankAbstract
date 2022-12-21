using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class Customer : Person
    {
        private bool isPrivate;
        private List<Account> lstAccount;

        public List<Account> LstAccount { get { return lstAccount; } }

        public Customer(string name, string firstName, DateTime birthDate, bool isPrivate, List<Account> existingList = null) : base (name, firstName, birthDate )
        {
            this.isPrivate= isPrivate;

            lstAccount = (existingList == null) ? new List<Account>() : existingList;
        }

        /// <summary>
        /// Adds an account to a customer's account list
        /// </summary>
        /// <param name="account"></param>
        /// <exception cref="AccountNotExistingException"></exception>
        public void AddAccount(Account account)
        {
            if (account == null) throw new AccountNotExistingException();
            lstAccount.Add(account);
        }
    }
}
