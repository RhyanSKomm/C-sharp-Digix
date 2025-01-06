using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula21_OO_Enumerate
{
    public class OrderItem
    {
        int quantity;
        double price;

        public OrderItem(int quantity, double price)
        {
            this.quantity = quantity;
            this.price = price;
        }

        public double subTotal()
        {
            return quantity * price;
        }
    }
}