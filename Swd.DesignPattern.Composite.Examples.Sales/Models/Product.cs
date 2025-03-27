using Swd.DesignPattern.Composite.Examples.Sales.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.DesignPattern.Composite.Examples.Sales.Models
{
	public class Product : ISalesItem
	{

		private string _name;
		private decimal _price;

		public Product(string name, decimal price)
		{
			_name = name;
			_price = price;
		}

		public decimal GetPrice()
		{
			return _price;
		}

		public void Display()
		{
			Console.WriteLine($"{_name}: ${_price}");
		}

	}
}
