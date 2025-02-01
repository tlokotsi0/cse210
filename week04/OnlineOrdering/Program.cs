using System;

class Program
{
    static void Main()
    {
        // Create addresses
        var address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        var address2 = new Address("456 Oak St", "Vancouver", "BC", "Canada");

        // Create customers
        var customer1 = new Customer("John Doe", address1);
        var customer2 = new Customer("Jane Smith", address2);

        // Create orders
        var order1 = new Order(customer1);
        var order2 = new Order(customer2);

        // Add products to order 1
        order1.AddProduct(new Product("Laptop", "P001", 800.00m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.00m, 2));

        // Add products to order 2
        order2.AddProduct(new Product("Smartphone", "P003", 500.00m, 1));
        order2.AddProduct(new Product("Headphones", "P004", 75.00m, 3));

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}\n");
    }
}
