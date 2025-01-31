using System;

class Program
{
    static void Main(string[] args)
    {
        // Address:
        Address address1 = new Address("50 West North Temple Street", "Salt Lake City", "Utah", "USA");
        Address address2 = new Address("Jr. Crespo y Castillo 2944", "Lima", "Lima", "Peru");

        // Customer:
        Customer customer1 = new Customer("Gordon Bitner", address1);
        Customer customer2 = new Customer("Donny Dianderas", address2);
        
        // Products
        Product product1 = new Product("Smartphone", "S24", 2000, 2);
        Product product2 = new Product("Camera", "C-103", 1000, 1);
        Product product3 = new Product("Headphones", "HPX-02", 100, 1);
        Product product4 = new Product("Mouse", "g203", 50, 1);

        // Order
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to order
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + "-" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + "-" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" +  order1.GetTotalPrice());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:\n" + "-" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + "-" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}