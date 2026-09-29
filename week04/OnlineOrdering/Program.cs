using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1: USA Customer ---
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 79.50, 1));
        order1.AddProduct(new Product("Desk Mat", "P103", 15.00, 1));

        // --- Order 2: International Customer ---
        Address address2 = new Address("456 Park Rd", "Pretoria", "Gauteng", "South Africa");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Cable", "P201", 9.99, 3));
        order2.AddProduct(new Product("HD Monitor", "P202", 180.00, 1));

        // --- Display Results for Order 1 ---
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("----------------------------------------\n");

        // --- Display Results for Order 2 ---
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("----------------------------------------");
    }
}