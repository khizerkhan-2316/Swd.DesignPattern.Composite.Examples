using Swd.DesignPattern.Composite.Examples.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.DesignPattern.Composite.Examples.Menu.Models
{
	public class MenuItem : IMenuComponent
	{
		public string Name { get; set; }
		public MenuItem(string name)
		{
			Name = name;
		}
		public void Display()
		{
			Console.WriteLine(Name);
		}


	}
}
