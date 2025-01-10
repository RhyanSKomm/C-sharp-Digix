using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Exercicios_09_01_2025
{
    public class Execute
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(1, new Address("Rua 1", "Cidade 1", State.SP));
            
            ATM atmSP = new ATM(State.MS, "Joca");

            System.Console.WriteLine("Bem Vindo ao Banco");

            while (true)
            {
                System.Console.WriteLine("Digite uma opção:\n1-Acessar minha conta.\n2-Criar uma conta\n3-Sair");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        System.Console.WriteLine("Digite o número de sua conta: ");
                        int nAcc = int.Parse(Console.ReadLine());
                        Account account = bank.GetAccount(nAcc);

                        if (account == null)
                        {
                            Console.WriteLine("Conta não encontrada.");
                            break;
                        }

                        System.Console.WriteLine("Digite o Pin: ");
                        int pin = int.Parse(Console.ReadLine());

                        try
                        {
                            account.VerifyPassword(pin);
                            
                        }
                        catch (Exception ex)
                        {
                            
                            System.Console.WriteLine(ex.Message);
                            break;
                        }

                        while (true)
                        {
                            System.Console.WriteLine("Digite uma opção:\n1-Depositar.\n2-Sacar\n3-Realizar nova transação\n4-Histórico de transações\n5-sair");
                            int option2 = int.Parse(Console.ReadLine());

                            switch (option2)
                            {
                                case 1:
                                    System.Console.WriteLine("Digite o valor para depósito: ");
                                    double deposito = double.Parse(Console.ReadLine());
                                    account.Deposit(deposito);
                                    break;

                                case 2:
                                    System.Console.WriteLine("Digite o valor para saque: ");
                                    double saque = double.Parse(Console.ReadLine());
                                    account.Withdraw(saque);
                                    break;

                                case 3:
                                    System.Console.WriteLine("Digite:\n1-Depósito\n2-Saque");
                                    int opTransacao = int.Parse(Console.ReadLine());
                                    if (opTransacao == 1)
                                    {
                                        System.Console.WriteLine("Digite o valor para depósito: ");
                                        double depositoTransacao = double.Parse(Console.ReadLine());

                                        ATMTransactions novatransacao = new ATMTransactions(account, TypeTransaction.Deposit, depositoTransacao);

                                        account.CreateTransaction(novatransacao);
                                    }
                                    if (opTransacao == 2)
                                    {
                                        System.Console.WriteLine("Digite o valor para saque: ");
                                        double saqueTransacao = double.Parse(Console.ReadLine());

                                        ATMTransactions novatransacao = new ATMTransactions(account, TypeTransaction.Withdraw, saqueTransacao);

                                        account.CreateTransaction(novatransacao);
                                    }
                                    break;

                                case 4:
                                    account.ShowTransactions();
                                    break;
                                
                                case 5:
                                    System.Console.WriteLine("Saindo...");
                                    return;
                            }
                        }
                    case 2:
                        System.Console.WriteLine("Vamos criar uma conta em nosso banco!");
                        
                        System.Console.WriteLine("Digite seu nome: ");
                        string nome = Console.ReadLine();

                        System.Console.WriteLine("Digite sua rua: ");
                        string rua = Console.ReadLine();
                        System.Console.WriteLine("Digite sua Cidade: ");
                        string cidade = Console.ReadLine();
                        System.Console.WriteLine("Digite a sigla de seu Estado: ");
                        string estado = Console.ReadLine();
                        
                        State estados;
                        if (!Enum.TryParse(estado, true, out estados))
                        {
                            Console.WriteLine("Estado inválido.");
                            break;
                        }
                        Address endereco = new Address(rua,cidade,estados);

                        System.Console.WriteLine("Digite sua data de nascimento (dd/MM/yyyy)");
                        DateTime dob = DateTime.Parse(Console.ReadLine());

                        Random random = new Random();
                        int cardNumber = random.Next(1000, 9999);

                        System.Console.WriteLine("Digite o PIN: ");
                        int pin2 = int.Parse(Console.ReadLine());

                        int numberAccount = random.Next(1000, 9999);

                        System.Console.WriteLine("Digite o saldo inicial: ");
                        double saldoInicial = double.Parse(Console.ReadLine());

                        System.Console.WriteLine("Digite o tipo de conta:\nCorrente\nPoupanca");
                        string tipoConta = Console.ReadLine();
                        TypeAccount typeAccount;
                        if (!Enum.TryParse(tipoConta, true, out typeAccount))
                        {
                            System.Console.WriteLine("Tipo inválido");
                            break;
                        }

                        Account account1 = new Account(nome, endereco, dob, cardNumber, pin2, numberAccount, saldoInicial, typeAccount);
                        bank.CreateAccount(account1);
                        Console.WriteLine($"Conta criada com sucesso! Número da conta: {numberAccount}, PIN: {pin2}");
                        break;
                    case 3:
                        System.Console.WriteLine("Saindo...");
                        return;
                }
            }
        }
    }
}