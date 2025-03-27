using Swd.DesignPattern.Composite.Examples.Sales.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.DesignPattern.Composite.Examples.Sales.Models
{
	public class ProductBundle : ISalesItem, IObserver
	{

		private string _bundleName;
		private readonly List<ISalesItem> _items;
		private decimal _cachedPrice;
		private bool _isDirty;


		public ProductBundle(string bundleName)
		{
			_bundleName = bundleName;
			_items = new List<ISalesItem>();
			_isDirty = true;
		}

		public void Add(ISalesItem item)
		{
			_items.Add(item);
			if (item is ISubject subject)
			{
				subject.Attach(this);  // Observe price changes of products
			}
			_isDirty = true;  // Mark cache as outdated
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
			if (_isDirty)
			{
				_cachedPrice = 0;
				foreach (var item in _items)
				{
					_cachedPrice += item.GetPrice();
				}
				_isDirty = false;  // Update cache status
			}
			return _cachedPrice;
		}

		public void Update()
		{
			_isDirty = true;
		}
	}
}
