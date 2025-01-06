using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula21_OO_Enumerate
{
    public class Product
    {
        string? name;
        double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}