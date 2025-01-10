using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioDia09;

namespace ExercicioDia09
{
    class Executar
    {
        static void Main(string[] args)
        {
            Bank banco = new Bank(1, "Rua dos Bancos, 123");

            Customer cliente1 = new Customer(1, "Rua A, 100", new DateTime(1990, 5, 10), 123456, 1234);
            Customer cliente2 = new Customer(2, "Rua B, 200", new DateTime(1985, 3, 15), 654321, 4321);

            SavingAccount contaPoupanca1 = new SavingAccount(102, 1000, 700, new DateTime(1999, 3, 21));
            CurrentAccount contaCorrente1 = new CurrentAccount(102, 1000, 700, new DateTime(1999, 3, 21));

            banco.AddAccount(contaPoupanca1);
            banco.AddAccount(contaCorrente1);

            Console.WriteLine("Cliente 1 tentando fazer login:");
            cliente1.VerifyPassword(1234);
            Console.WriteLine();

            Console.WriteLine("Cliente 1 realizando transações:");
            contaPoupanca1.Deposit(500);
            contaPoupanca1.WithDraw(1000); 
            contaPoupanca1.WithDraw(200); 
            contaPoupanca1.ShowTransactionHistory();
            Console.WriteLine();

           
            Console.WriteLine("Cliente 2 tentando fazer login:");
            cliente2.VerifyPassword(1234); 
            Console.WriteLine();

            ATM atm = new ATM("Rua dos Caixas Eletrônicos, 400", "Banco XYZ", new List<ATMTransactions>());
            ATMTransactions deposito = new ATMTransactions(1, DateTime.Now, 1000, contaPoupanca1.Balance, Type.Deposit);
            atm.Transactions.Add(deposito);
            deposito.Modifies();
            contaPoupanca1.ShowTransactionHistory();
            
            banco.SearchAccount(102); 
            Console.WriteLine();
            
            Console.WriteLine("Listando todas as contas:");
            banco.ListAllAccounts();
        }
    }
}