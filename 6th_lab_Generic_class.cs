using System;
using System.Collections.Generic;

class Product
{
    public int Product_ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int productId, string name, double price)
    {
        Product_ID = productId;
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main()
    {
        // Create a List<T> to store products
        List<Product> products = new List<Product>();

        // Add products to the list
        products.Add(new Product(101, "Laptop", 55000));
        products.Add(new Product(102, "Mouse", 750));
        products.Add(new Product(103, "Keyboard", 1500));
        products.Add(new Product(104, "Monitor", 12000));

        // Display product details
        Console.WriteLine("Product Details:\n");

        foreach (var product in products)
        {
            Console.WriteLine($"Product ID: {product.Product_ID}, Name: {product.Name}, Price: ₹{product.Price}");
        }
    }
}
