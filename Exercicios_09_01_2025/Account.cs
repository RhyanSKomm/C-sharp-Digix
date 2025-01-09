using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using Aula_23_OO_Excessao.Resolucao_3;

namespace Exercicios_09_01_2025
{
    public class Account : Customer
    {
        public int NumberAccount { get; set; }
        public double Balance { get; set; }
        public TypeAccount TypeAcc { get; set; }
        public List<ATMTransactions> Transactions = new List<ATMTransactions>();

        public Account(string name, Address address, DateTime dob, int cardNumber, int pin, int numberAccount, double balance, TypeAccount typeAccount) : base(name, address, dob, cardNumber, pin)
        {
            TimeSpan idade = DateTime.Now.Subtract(dob);
            if (balance < 0)
            {
                throw new DomainException("Erro no saldo: Não é possível criar um saldo negativo");
            }
            if (typeAccount == TypeAccount.CurrentAccount && (int)idade.TotalDays < 18)
            {
                throw new DomainException("Erro de idade: Não é possível cria Conta Corrente para menor de 18 anos");
            }
            NumberAccount = numberAccount;
            Balance = balance;
            TypeAcc = typeAccount;
        }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new DomainException("Erro de valor: Não é possível depositar um valor nulo");
            }
            
            Balance += value;
            System.Console.WriteLine($"Foi Depositado R${value}.");
        }

        public void Withdraw(double value)
        {
            if (Balance < 0)
            {
                throw new DomainException("Erro de saldo: Saldo insuficiente para saque")
            }
            if (value > Balance)
            {
                throw new DomainException("Erro de saldo: O valor excede o saldo");
            }
                Balance -= value;
                System.Console.WriteLine($"Saque R$ " + value);
        }

        public void CreateTransaction (ATMTransactions newTransaction)
        {
            Balance = newTransaction.PostBalance;
            Transactions.Add(newTransaction);
        }

        public void ShowTransactions()
        {
            foreach (var transaction in Transactions)
            {
                Console.WriteLine("Transaction ID: " + transaction.TransactionID);
                Console.WriteLine("Date: " + transaction.Date);
                Console.WriteLine("Type of transaction: " + transaction.TypeTransaction);
                Console.WriteLine("Amount: " + transaction.Amount);
                Console.WriteLine("Post balance: " + transaction.PostBalance);
            }
        }
    }
}