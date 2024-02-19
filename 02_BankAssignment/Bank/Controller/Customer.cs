using System;
using System.Collections.Generic;
using Bank.Controller;


namespace Bank.Controller
{
    public class Customer // luokka tilien luontiin
    {
        private readonly string m_customerName;
        private readonly List<Bank.Controller.Account> m_accounts; // listaan voi lisätä yhdelle asiakkaalle useamman tilin

        public Customer(string customerName)
        {
            if (string.IsNullOrWhiteSpace(customerName))
            {
                throw new ArgumentNullException("Customer name can't be null or empty", nameof(customerName));
            }
            m_customerName = customerName;
            m_accounts = new List<Bank.Controller.Account>();
        }

        public string CustomerName => m_customerName;
        public IReadOnlyList<Bank.Controller.Account> Accounts => m_accounts;
        public void AddAccount(Bank.Controller.Account account) // metodi tilin lisäämiseen 
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account), "Account can't be null");
            }
            m_accounts.Add(account);
        }
        public void RemoveAccount(Bank.Controller.Account account) // metodi tilin poistamiseen
        {
            if (account == null) 
            {
                throw new ArgumentNullException(nameof(account), "Account can't be null");
            }
            m_accounts.Remove(account);
        }
    }
}