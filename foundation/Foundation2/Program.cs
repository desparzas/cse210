using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 FH", "Lima", "LI", "Peru");

        Customer customer1 = new Customer("David Esparza", address1);
        Customer customer2 = new Customer("Alberto Esparza", address2);

        Product product1 = new Product("Laptop", "A123", 1000m, 1);
        Product product2 = new Product("Mouse", "B456", 25m, 2);
        Product product3 = new Product("Monitor", "C789", 200m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}