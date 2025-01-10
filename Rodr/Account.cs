using System;
using System.Collections.Generic;

namespace ExercicioDia09
{
    public class Account
    {
        public double Amount { get; set; }
        public int Number { get; set; }
        public double Balance { get; set; }
        public DateTime Dob { get; set; } 
        private List<string> transactionHistory;

        public Account(int number, double balance, DateTime dob)
        {
            if (balance < 0.0)
            {
                throw new DomainException("Balance cannot be negative");
            }
            if (CalculateAge(dob) < 18)
            {
                throw new DomainException("You must be 18 years old to open an account");
            }
            Number = number;
            Balance = balance;
            Dob = dob;
            transactionHistory = new List<string>();
        }

        private int CalculateAge(DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age)) age--;
            return age;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0.0)
            {
                throw new DomainException("Deposit amount must be positive");
            }
            Balance += amount;
            AddTransaction($"Deposited: {amount:C}");
        }

        public void WithDraw(double amount)
        {
            if (amount <= 0.0)
            {
                throw new DomainException("Withdraw amount must be positive");
            }
            if (amount > Balance)
            {
                throw new DomainException("Insufficient funds");
            }
            Balance -= amount;
            AddTransaction($"Withdrew: {amount:C}");
        }

        private void AddTransaction(string transaction)
        {
            transactionHistory.Add($"{DateTime.Now}: {transaction}");
        }

        public void ShowTransactionHistory()
        {
            if (transactionHistory.Count == 0)
            {
                Console.WriteLine("No transactions have been made.");
                return;
            }

            Console.WriteLine("Transaction History:");
            foreach (var transaction in transactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}