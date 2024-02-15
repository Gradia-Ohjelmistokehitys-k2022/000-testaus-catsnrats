using System;
using System.Collections.Generic;
using Bank.Controller;


namespace Bank.Controller
{
    public class Customer // luokka tilien luontiin
    {
        private readonly string m_customerName;
        private readonly List<BankAccount.Bank> m_accounts; // listaan voi lisätä yhdelle asiakkaalle useamman tilin

        public Customer(string customerName)
        {
            if (string.IsNullOrWhiteSpace(customerName))
            {
                throw new ArgumentNullException("Customer name can't be null or empty", nameof(customerName));
            }
            m_customerName = customerName;
            m_accounts = new List<BankAccount.Bank>();
        }

        public string CustomerName => m_customerName;
        public IReadOnlyList<BankAccount.Bank> Accounts => m_accounts;
        public void AddAccount(BankAccount.Bank account) // metodi tilin lisäämiseen 
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account), "Account can't be null");
            }
            m_accounts.Add(account);
        }
    }
}
