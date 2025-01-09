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
                        
                    default:
                }
            }
        }
    }
}