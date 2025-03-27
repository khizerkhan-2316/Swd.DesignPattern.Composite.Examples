using Swd.DesignPattern.Composite.Examples.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.DesignPattern.Composite.Examples.Menu.Models
{
	public class Menu : IMenuComponent
	{

		public string Name { get; set; }

		private readonly List<IMenuComponent> _items;

		public Menu(string name)
		{
			Name = name;
			_items = new List<IMenuComponent>();
		}

		public void Add(IMenuComponent item)
		{
			if(_items.Contains(item))
			{
				throw new InvalidOperationException("Item already exists");
			}

			_items.Add(item);
		}

		public void Remove(IMenuComponent item)
		{

			if (!_items.Contains(item))
			{
				throw new InvalidOperationException("Item dont exists");
			}

			_items.Remove(item);
		}

		public void Display()
		{
			Console.WriteLine(Name);
			foreach (var item in _items)
			{
				item.Display();
			}
		}
	}
}
