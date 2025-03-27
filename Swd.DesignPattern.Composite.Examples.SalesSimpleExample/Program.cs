using Swd.DesignPattern.Composite.Examples.SalesSimpleExample.Models;
using System;

namespace Swd.DesignPattern.Composite.Examples.SalesSimpleExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create individual products
            var Laptop = new Product("Laptop", 1000);
            var Mouse = new Product("Mouse", 25);
            var Keyboard = new Product("Keyboard", 75);

            // Create a product bundle
            var electronicsBundle = new ProductBundle("Electronics Bundle");
            electronicsBundle.Add(Laptop);
            electronicsBundle.Add(Mouse);
            electronicsBundle.Add(Keyboard);

            // Create another individual product
            var product4 = new Product("Headphones", 150);

            // Create a sales bundle containing another bundle and an individual product
            var ultimateBundle = new ProductBundle("Ultimate Bundle");
            ultimateBundle.Add(electronicsBundle);
            ultimateBundle.Add(product4);

            // Display details and calculate prices
            Console.WriteLine("Displaying individual product:");
            Laptop.Display();
            Console.WriteLine($"Price: ${Laptop.GetPrice()}\n");

            Console.WriteLine("Displaying product bundle:");
            electronicsBundle.Display();
            Console.WriteLine($"Price: ${electronicsBundle.GetPrice()}\n");

            Console.WriteLine("Displaying ultimate bundle:");
            ultimateBundle.Display();
            Console.WriteLine($"Price: ${ultimateBundle.GetPrice()}\n");
        }
    }
}