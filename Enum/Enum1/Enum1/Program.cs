using System;
using Enum1.Entities;
using Enum1.Entities.Enums;

namespace Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
        
            Console.WriteLine(order);

            String txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);

            Console.WriteLine(os);
        }
    }
}
