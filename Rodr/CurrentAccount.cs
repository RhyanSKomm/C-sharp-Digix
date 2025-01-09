using System;

namespace ExercicioDia09
{
   
    public class CurrentAccount
    {
        public int AccountNo { get; set; }  
        public double Balance { get; set; }

    
        public CurrentAccount(int accountNo, double balance)
        {
            AccountNo = accountNo;  
            Balance = balance;      
        }

       
        public void WithDraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
    }
}
