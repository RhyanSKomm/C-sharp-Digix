using System;

namespace ExercicioDia09
{
    public class SavingAccount
    {
        public int AccountNo { get; set; } 
        public double Balance { get; set; }

     
        public SavingAccount(int accountNo, double balance)
        {
            AccountNo = accountNo;  
            Balance = balance;      
        }
    }
}
