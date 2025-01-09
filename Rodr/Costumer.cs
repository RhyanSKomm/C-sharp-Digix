using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDia09
{
    public class Costumer
    {
        public int Number { get; set; }
        public string Adress { get; set; }
        public DateTime Dob { get; set; }
        public int CardNumber { get; set; }
        public int Pin { get; set; }
        public Costumer(int number, string adress, DateTime dob, int cardNumber, int pin)
        {
            Number = number;
            Adress = adress;
            Dob = dob;
            CardNumber = cardNumber;
            Pin = pin;
        }
        public void VerifyPassword(int pin)
        {
            if (pin == Pin)
            {
                System.Console.WriteLine("Password is correct");
            }
            else
            {
                System.Console.WriteLine("Password is incorrect");
            }
        }
    }
}