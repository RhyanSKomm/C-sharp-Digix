using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Excessao.Exercicio
{
    public class ExecutarEx
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com os dados da conta");
            System.Console.WriteLine("Numero da conta: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Titular da conta: ");
            string holder = Console.ReadLine();
            System.Console.WriteLine("Saldo inicial: ");
            double balance = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Limite de saque: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, withdrawLimit);

            try
            {
                System.Console.WriteLine("Entre com o valor para saque: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
                System.Console.WriteLine("Novo saldo: " + account.Balance);
            }
            catch (DomainException e)
            {
                System.Console.WriteLine("Erro de saque: " + e.Message);
            }
            catch (FormatException e)
            {
                System.Console.WriteLine("Erro de formato: " + e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}