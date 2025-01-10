using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_23_OO_Excessao.Resolucao_3;

namespace Exercicios_09_01_2025
{
    public class ATMTransactions
    {
        public Guid TransactionID { get; set; }
        public DateTime Date { get; set; }
        public TypeTransaction TypeTransaction { get; set; }
        public double Amount { get; set; }
        public double PostBalance { get; set; }
        public State Location { get; set; }
        private Account account;
        

        public ATMTransactions(Account account, TypeTransaction typeTransaction, double amount)
        {
            this.account = account;
            TransactionID = Guid.NewGuid();
            Date = DateTime.Now;
            TypeTransaction = typeTransaction;
            Amount = amount;
            PostBalance = account.Balance;
            Location = account.Address.State;
        }

        public void Modifies()
        {
            if (TypeTransaction == TypeTransaction.Deposit)
            {
                if (Amount <= 0)
                {
                    throw new DomainException("Erro de valor: Não é possível depositar um valor nulo");
                }

                PostBalance += Amount;
                System.Console.WriteLine($"Foi Depositado R${Amount}.");
            }
            else if (TypeTransaction == TypeTransaction.Withdraw)
            {
                if (PostBalance < 0)
                {
                    throw new DomainException("Erro de saldo: Saldo insuficiente para saque");
                }
                else if (Amount > PostBalance)
                {
                    throw new DomainException("Erro de saldo: O valor excede o saldo");
                }
                PostBalance -= Amount;
                System.Console.WriteLine($"Saque R$ " + Amount);
            }
        }
    }
}