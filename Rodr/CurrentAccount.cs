using System;

namespace ExercicioDia09
{
    public class CurrentAccount : Account
    {
        public int AccountNo { get; set; }

        public CurrentAccount(int accountNo, int number, double balance, DateTime dob ) : base(number, balance, dob)
        {
            AccountNo = accountNo;
        }

        public void WithDraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
        }


        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }


        public void Transfer(double amount, string targetAccount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para a transferência.");
            }
        }
    }
}