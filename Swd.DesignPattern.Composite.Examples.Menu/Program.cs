using Swd.DesignPattern.Composite.Examples.Menu.Interfaces;
using Swd.DesignPattern.Composite.Examples.Menu.Models;

class Program
{
	static void Main()
	{
		// Creating individual menu items (leaves)
		IMenuComponent save = new MenuItem("Save");
		IMenuComponent open = new MenuItem("Open");
		IMenuComponent exit = new MenuItem("Exit");

		// Creating a submenu (composite)
		Menu fileMenu = new Menu("File");
		fileMenu.Add(open);
		fileMenu.Add(save);
		fileMenu.Add(exit);

		// Creating another submenu
		IMenuComponent copy = new MenuItem("Copy");
		IMenuComponent paste = new MenuItem("Paste");

		Menu editMenu = new Menu("Edit");
		editMenu.Add(copy);
		editMenu.Add(paste);

		// Creating the main menu
		Menu mainMenu = new Menu("Main Menu");
		mainMenu.Add(fileMenu);
		mainMenu.Add(editMenu);

		// Executing the main menu
		Console.WriteLine("=== Running Menu System ===");
		mainMenu.Display();
	}
}