using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_09_01_2025
{
    public class Bank
    {
        public int Code { get; set; }
        public Address Address { get; set; }
        public List<Account> Accounts = new List<Account>();
        public List<ATM> Atms = new List<ATM>();

        public Bank(int code, Address address)
        {
            Code = code;
            Address = address;
        }

        public void Manages()
        {
            Console.WriteLine("Bank code: " + Code);
            Console.WriteLine("Address: " + Address.Street + ", " + Address.City + " - " + Address.State);
        }

        public void Maintains()
        {
            foreach (var atm in Atms)
            {
                Console.WriteLine("ATM located in " + atm.Location + " managed by " + atm.ManagedBy);
            }
        }

        public void CreateAccount(Account account)
        {
            Accounts.Add(account);
        }

        public void ListAccounts()
        {
            foreach (var account in Accounts)
            {
                Console.WriteLine("Account number: " + account.NumberAccount);
            }
        }

        public void SearchAccount(int number)
        {
            foreach (var account in Accounts)
            {
                if (account.NumberAccount == number)
                {
                    Console.WriteLine("Account number: " + account.NumberAccount);
                    Console.WriteLine("Balance: " + account.Balance);
                }
            }
        }

        public Account GetAccount(int accountNumber)
        {
            return Accounts.Find(a => a.NumberAccount == accountNumber);
        } 
    }
}