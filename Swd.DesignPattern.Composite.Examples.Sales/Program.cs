using Swd.DesignPattern.Composite.Examples.Sales.Models;

class Program
{
	static void Main(string[] args)
	{
		// Create individual products
		var laptop = new Product("Laptop", 1000);
		var mouse = new Product("Mouse", 25);
		var keyboard = new Product("Keyboard", 75);

		// Create a product bundle
		var electronicsBundle = new ProductBundle("Electronics Bundle");
		electronicsBundle.Add(laptop);
		electronicsBundle.Add(mouse);
		electronicsBundle.Add(keyboard);

		// Create another individual product
		var headphones = new Product("Headphones", 150);

		// Create a sales bundle containing another bundle and an individual product
		var ultimateBundle = new ProductBundle("Ultimate Bundle");
		ultimateBundle.Add(electronicsBundle);
		ultimateBundle.Add(headphones);

		// Display initial bundle prices
		Console.WriteLine("\n--- Initial Prices ---");
		ultimateBundle.Display();

		// Change the price of an individual product and observe automatic updates
		Console.WriteLine("\n--- Updating Laptop Price to $1200 ---");
		laptop.SetPrice(1200);  // This should trigger updates in all affected bundles

		// Display updated prices
		ultimateBundle.Display();
	}
}
