using Swd.DesignPattern.Composite.Examples.SalesSimpleExample.Models;
using System;

namespace Swd.DesignPattern.Composite.Examples.SalesSimpleExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create individual products
            var product1 = new Product("Laptop", 1000);
            var product2 = new Product("Mouse", 25);
            var product3 = new Product("Keyboard", 75);

            // Create a product bundle
            var electronicsBundle = new ProductBundle("Electronics Bundle");
            electronicsBundle.Add(product1);
            electronicsBundle.Add(product2);
            electronicsBundle.Add(product3);

            // Create another individual product
            var product4 = new Product("Headphones", 150);

            // Create a sales bundle containing another bundle and an individual product
            var ultimateBundle = new ProductBundle("Ultimate Bundle");
            ultimateBundle.Add(electronicsBundle);
            ultimateBundle.Add(product4);

            // Display details and calculate prices
            Console.WriteLine("Displaying individual product:");
            product1.Display();
            Console.WriteLine($"Price: ${product1.GetPrice()}\n");

            Console.WriteLine("Displaying product bundle:");
            electronicsBundle.Display();
            Console.WriteLine($"Price: ${electronicsBundle.GetPrice()}\n");

            Console.WriteLine("Displaying ultimate bundle:");
            ultimateBundle.Display();
            Console.WriteLine($"Price: ${ultimateBundle.GetPrice()}\n");
        }
    }
}