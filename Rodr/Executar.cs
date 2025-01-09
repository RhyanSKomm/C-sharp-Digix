using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDia09
{
    public class Executar
    {
        static void Main(string[] args)
        {
            CurrentAccount currentAccount = new CurrentAccount(123, 1000);
            currentAccount.WithDraw(500);
            currentAccount.WithDraw(600);
            currentAccount.WithDraw(100);
            Customer customer = new Customer("John", "Doe", currentAccount);
            bankAccount.Deposit(1000);
            ATM atm = new ATM("Sao Paulo", "John Doe", new List<ATMTransactions>());
            atm.Identifies();


            SavingAccount savingAccount = new SavingAccount(456, 1000);
            Console.WriteLine("Histórico de Transações (Conta Corrente):");
        currentAccount.DisplayTransactions();

        Console.WriteLine("Histórico de Transações (Conta Poupança):");
        savingAccount.DisplayTransactions();
        }
    }
}