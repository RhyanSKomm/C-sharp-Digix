using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioDia09
{
    public class Bank
    {
        public int Code { get; set; }
        public string Adress { get; set; }
        private List<Account> accounts;

        public Bank(int code, string adress)
        {
            Code = code;
            Adress = adress;
            accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void ListAllAccounts()
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Account Number: {account.Number}, Balance: {account.Balance:C}");
            }
        }

        public void SearchAccount(int accountNumber)
        {
            var account = accounts.FirstOrDefault(a => a.Number == accountNumber);
            if (account != null)
            {
                Console.WriteLine($"Account found: {account.Number}, Balance: {account.Balance:C}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}