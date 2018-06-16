using System;

namespace CsharpIntermediate
{}

    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer(); - repeating the word twice will make cluter
            var customer = new Customer(1, "John");
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            // customer.Orders = new List<Order>();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}