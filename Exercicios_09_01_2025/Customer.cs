using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public void verifyPassword(int pin)
        {
            if (Pin == pin)
            {
                Console.WriteLine("Pin correct");
            }
            else
            {
                Console.WriteLine("Pin incorrect");
            }
        }

    }
}