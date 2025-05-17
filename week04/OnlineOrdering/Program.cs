using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address addr1 = new Address("123 Main St", "Idaho Falls", "ID", "USA");
        Customer cust1 = new Customer("Mr. Greg Smith", addr1);
        Address addr2 = new Address("456 Cool Road", "London", "London", "UK");
        Customer cust2 = new Customer("Mr. John Jones", addr2);

        Product product1 = new Product("Wireless Mouse", 1, 29.99, 2);
        Product product2 = new Product("Mechanical Keyboard", 2, 89.99, 1);
        Product product3 = new Product("HDMI Cable", 3, 9.99, 3);

        Product product4 = new Product("Wireless Mouse", 1, 29.99, 1);
        Product product5 = new Product("Mechanical Keyboard", 2, 89.99, 2);
        Product product6 = new Product("HDMI Cable", 3, 9.99, 10);

        List<Product> productList1 = new List<Product> { product1, product2, product3 };
        Order order1 = new Order(productList1, cust1);

        Console.WriteLine("--- Packing Label for Customer 1 ---");
        Console.WriteLine(order1.PackingLabel());

        Console.WriteLine("\n--- Shipping Label for Customer 1 ---");
        Console.WriteLine(order1.ShippingLabel());

        List<Product> productList2 = new List<Product> { product4, product5, product6 };
        Order order2 = new Order(productList2, cust2);

        Console.WriteLine("\n--- Packing Label for Customer 2 ---");
        Console.WriteLine(order2.PackingLabel());

        Console.WriteLine("\n--- Shipping Label for Customer 2 ---");
        Console.WriteLine(order2.ShippingLabel());
        

    }
}