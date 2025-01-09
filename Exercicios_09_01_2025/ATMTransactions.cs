using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_09_01_2025
{
    public class ATMTransactions
    {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public TypeTransaction TypeTransaction { get; set; }
        public double Amount { get; set; }
        public double PostBalance { get; set; }
        public State Location { get; set; }

        public ATMTransactions(int transactionID, DateTime date, TypeTransaction typeTransaction, double amount, double postBalance, State location)
        {
            if (transactionID )
            TransactionID = transactionID;
            Date = date;
            TypeTransaction = typeTransaction;
            Amount = amount;
            PostBalance = postBalance;
            Location = location;
        }

        public void Modifies()
        {
            if (TypeTransaction == TypeTransaction.Deposit)
            {
                if (Amount > 0)
                {
                    PostBalance += Amount;
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
            else if (TypeTransaction == TypeTransaction.Withdraw)
            {
                if (PostBalance < 0)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else if (Amount > PostBalance)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    PostBalance -= Amount;
                    System.Console.WriteLine("Withdrawal successful in the amount of R$ " + Amount);
                }
            }
        }
    }
}