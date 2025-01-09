using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_09_01_2025
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public State State { get; set; }

        public Address(string street, string city, State state)
        {
            Street = street;
            City = city;
            State = state;
        }
    }
}