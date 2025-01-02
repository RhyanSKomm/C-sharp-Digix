using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO_Encapsulamento
{
    public class Banco
    {
        protected int _NumeroDaConta;
        public string NomeDoTitular { get;set;}
        private double _Saldo;

        public Banco(int numeroConta, string nomeTitular)
        {
            _NumeroDaConta = numeroConta;
            NomeDoTitular = nomeTitular;
        }

        public Banco(int numeroConta, string nomeTitular, double saldoInicial) : this(numeroConta, nomeTitular)
        {
            _Saldo = saldoInicial;
        }

        public void Depositar(double deposito)
        {
            _Saldo+= deposito;

            System.Console.WriteLine("Depósito: " + deposito + " Saldo: " + _Saldo);
            System.Console.WriteLine();
        }

        public void Sacar(double saque)
        {
            _Saldo -= saque+5;
            System.Console.WriteLine("Saque: " + saque + " Saldo: " + _Saldo);
            System.Console.WriteLine();
        }
    }
}