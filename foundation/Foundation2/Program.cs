using System;

class Program
{
    static void Main(string[] args)
{

        Address address1 = new Address("62 Coronel St", "Springfield", "IL", "USA");
        Address address2 = new Address("3656 Trophy Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Neymar Santos", address1);
        Customer customer2 = new Customer("Matias Gutierrez", address2);

        Product product1 = new Product("Laptop", "A001", 899.99, 1);
        Product product2 = new Product("Headphones", "B002", 79.99, 2);
        Product product3 = new Product("Keyboard", "C003", 29.99, 1);
        Product product4 = new Product("Taco", "D004", 9.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}\n");
    }
}