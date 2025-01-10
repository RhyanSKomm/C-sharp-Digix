using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_23_OO_Excessao.Resolucao_3;

namespace Exercicios_09_01_2025
{
    public class Customer 
    {
        public string Name { get; set; }
        public Address Address  { get; set; }
        public DateTime Dob { get; set; }
        public int CardNumber { get; set; }
        public int Pin { get; set; }

        public Customer(string name, Address address, DateTime dob, int cardNumber, int pin)
        {
            Name = name;
            Address = address;
            Dob = dob;
            CardNumber = cardNumber;
            Pin = pin;
        }

        public void VerifyPassword(int pin)
        {
            if (Pin != pin)
            {
                throw new DomainException("Erro de senha: Pin incorreto.");
            }
            System.Console.WriteLine("Pin correto!");
        }

    }
}