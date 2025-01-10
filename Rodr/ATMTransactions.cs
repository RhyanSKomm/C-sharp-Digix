using System;

namespace ExercicioDia09
{
    public class ATMTransactions : ITransaction
    {
        public int TransactionId { get; set; } 
        public DateTime Date { get; set; }
        public double Amount { get; set; }     
        public double PostBalance { get; set; }  
        public Type Type { get; set; }

        public ATMTransactions(int transactionId, DateTime date, double amount, double postBalance, Type type)
        {
            TransactionId = transactionId;
            Date = date;
            Amount = amount;
            PostBalance = postBalance;
            Type = type;
        }
        public void Deposit(double amount)
{
      PostBalance += amount;
}

public void Transfer(double amount, string targetAccount)
{
      PostBalance -= amount;
}

public void WithDraw(double amount)
{
    PostBalance -= amount;
}
        public void Modifies()
        {
            if (Type == Type.Deposit)
            {
                PostBalance += Amount;
            }
            else if (Type == Type.Withdraw)
            {
                PostBalance -= Amount;
            }
            else if (Type == Type.Transfer)
            {
                PostBalance -= Amount;
            }
        }
    }
  
}