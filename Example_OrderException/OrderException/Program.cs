using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderException
{
    class OrderException : Exception
    {
        public OrderException(String message) : base(message)
        {
            
        }
    }
    class OrderCheck
    {
        int Order;
        public OrderCheck(int  Order)
        {
            this.Order = Order;

        }
        public void OutOfStock()
        {
            if (Order>5)
                throw new OrderException("Order is greater than 5...Out of stock");
            else
                Console.WriteLine("Order {0} is less than 5 ", Order);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Order: ");
            int order = Convert.ToInt32(Console.ReadLine());
            OrderCheck obj = new OrderCheck(order);

            try
            {
                obj.OutOfStock();
            }
            catch (OrderException a)
            {
                Console.WriteLine(a.Message);
            }
            Console.ReadLine();
        }
        
    }
}
