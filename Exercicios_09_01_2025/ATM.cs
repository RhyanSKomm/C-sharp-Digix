using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_09_01_2025
{
    public class ATM
    {
        public State Location { get; set; }
        public string ManagedBy { get; set; }
        public List<ATMTransactions> Transactions = new List<ATMTransactions>();

        public ATM(State location, string managedBy)
        {
            Location = location;
            ManagedBy = managedBy;
        }

        public void Identifies()
        {
            Console.WriteLine("ATM located in " + Location + " managed by " + ManagedBy);
        }

        public void TransactionsForState()
        {
            foreach (var transaction in Transactions)
            {
                if (transaction.Location == Location)
                {
                    Console.WriteLine("\nTransaction ID: " + transaction.TransactionID);
                    Console.WriteLine("Date: " + transaction.Date);
                    Console.WriteLine("Type of transaction: " + transaction.TypeTransaction);
                    Console.WriteLine("Amount: " + transaction.Amount);
                    Console.WriteLine("Post balance: " + transaction.PostBalance);
                }
            }
        }
    }
}