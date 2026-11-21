using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // First customer in the USA
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // First order
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "P001", 800.00, 1);
        Product product2 = new Product("Mouse", "P002", 25.00, 2);
        Product product3 = new Product("Keyboard", "P003", 45.00, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Second customer outside the USA
        Address address2 = new Address(
            "15 Allen Avenue",
            "Lagos",
            "Lagos State",
            "Nigeria"
        );

        Customer customer2 = new Customer("David Johnson", address2);

        // Second order
        Order order2 = new Order(customer2);

        Product product4 = new Product("Smartphone", "P004", 500.00, 1);
        Product product5 = new Product("Headphones", "P005", 60.00, 2);
        Product product6 = new Product("Phone Case", "P006", 15.00, 3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Store orders in a list
        List<Order> orders = new List<Order>
        {
            order1,
            order2
        };

        // Display order information
        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"ORDER {orderNumber}");
            Console.WriteLine("==================================");

            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine();

            Console.WriteLine($"Total Order Cost: ${order.GetTotalCost():F2}");

            Console.WriteLine();

            orderNumber++;
        }
    }
}