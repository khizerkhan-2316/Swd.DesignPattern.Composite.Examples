using Swd.DesignPattern.Composite.Examples.Sales.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.DesignPattern.Composite.Examples.Sales.Models
{
	public class ProductBundle : ISalesItem, IObserver, ISubject
	{

		private string _bundleName;
		private readonly List<ISalesItem> _items;
		private List<IObserver> _observers;
		private decimal? _cachedPrice = null;
		private bool _isDirty;


		public ProductBundle(string bundleName)
		{
			_bundleName = bundleName;
			_items = new List<ISalesItem>();
			_observers = new List<IObserver>();
			_isDirty = true;
		}

		public void Add(ISalesItem item)
		{
			_items.Add(item);

			if (item is ISubject subject)
			{
				subject.Attach(this);
			}

			_isDirty = true; 
			Notify(); 
		}


		public void Remove(ISalesItem item)
		{
			_items.Remove(item);
			if (item is ISubject subject)
			{
				subject.Detach(this);  // Stop observing the removed product
			}
			_isDirty = true;  // Mark cache as outdated
		}

		public void Display()
		{
			Console.WriteLine($"{_bundleName} Bundle:");
			foreach (var item in _items)
			{
				item.Display();
			}

			Console.WriteLine($"Total Price: ${GetPrice()}");
		}

		public decimal GetPrice()
		{
			if (_isDirty || _cachedPrice == null)
			{
				_cachedPrice = _items.Sum(item => item.GetPrice());
				_isDirty = false;
			}
			return _cachedPrice.Value;
		}

		public void Update()
		{
			_isDirty = true;
			Notify();  // Notify parent bundles to update price
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
			_isDirty = true;  // Mark cache as outdated
			foreach (var observer in _observers)
			{
				observer.Update();
			}
		}



	}
}
