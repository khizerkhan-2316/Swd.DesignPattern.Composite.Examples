using Swd.DesignPattern.Composite.Examples.Sales.Interfaces;
using System;
using System.Collections.Generic;

namespace Swd.DesignPattern.Composite.Examples.Sales.Models
{
	public class Product : ISalesItem, ISubject
	{
		private string _name;
		private decimal _price;
		private List<IObserver> _observers = new List<IObserver>();

		public Product(string name, decimal price)
		{
			_name = name;
			_price = price;
		}

		public decimal GetPrice()
		{
			return _price;
		}

		public void SetPrice(decimal newPrice)
		{
			_price = newPrice;
			Notify();  
		}

		public void Display()
		{
			Console.WriteLine($"{_name}: ${_price}");
		}

		public void Attach(IObserver observer)
		{
			_observers.Add(observer);
		}

		public void Detach(IObserver observer)
		{
			_observers.Remove(observer);
		}

		public void Notify()
		{
			foreach (var observer in _observers)
			{
				observer.Update();
			}
		}
	}
}
