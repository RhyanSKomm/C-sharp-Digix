using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula21_OO_Enumerate
{
    public class Order
    {
        DateTime Moment { get; set; }
        OrderStatus Status { get; set; }
        List<OrderItem> items = new List<OrderItem>();


        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void addItem(OrderItem item)
        {
            items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            items.Remove(item);
        }

        public double total()
        {
            double sum = 0;
            foreach (OrderItem item in items)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public static void Main(string[] args)
        {
            Order order = new Order(DateTime.Now, OrderStatus.PendingPayment);
            OrderItem item1 = new OrderItem(2, 100.00);
            OrderItem item2 = new OrderItem(1, 50.00);

            order.addItem(item1);
            order.addItem(item2);

            Console.WriteLine(order.total());
        }
    }
}