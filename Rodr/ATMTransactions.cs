using System;

namespace ExercicioDia09
{
    public class ATMTransactions
    {
        public int TransactionId { get; set; }  // Corrigido para TransactionId
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }     // Alterado para decimal para valores financeiros
        public decimal PostBalance { get; set; }  // Alterado para decimal
        public TypeTransaction Type { get; set; }

        // Construtor
        public ATMTransactions(int transactionId, DateTime date, decimal amount, decimal postBalance)
        {
            TransactionId = transactionId;
            Date = date;
            Amount = amount;
            PostBalance = postBalance;
        }

        // Método para modificar o saldo
        public void Modifies()
        {
            if (Type == TypeTransaction.Deposit)
            {
                PostBalance += Amount;
            }
            else if (Type == TypeTransaction.Withdraw)
            {
                PostBalance -= Amount;
            }
        }
    }

    // Enum para tipos de transação
  
}
