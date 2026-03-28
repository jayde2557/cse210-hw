using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Apple Street", "New York", "NY", "USA");

        Customer customer1 = new Customer("John Carter", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Chromebook","CN67",800,1));
        order1.AddProduct(new Product("Professional Camera","HSR116",499,2));

        Console.WriteLine("===== ORDER 1 =====\n");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Address address2 = new Address("92 Banana Avenue", "Brentford", "BR", "UK");

        Customer customer2 = new Customer("Max Does", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Stan Lee Cup","HLS",35,1));
        order2.AddProduct(new Product("Professional Camera","HSR116",499,1));

        Console.WriteLine("===== ORDER 2 =====\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}\n");

    }
}