using Swd.DesignPattern.Composite.Examples.SalesSimpleExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.DesignPattern.Composite.Examples.SalesSimpleExample.Models
{
    public class ProductBundle : ISalesItem
    {

        private string _bundleName;
        private readonly List<ISalesItem> _items;


        public ProductBundle(string bundleName)
        {
            _bundleName = bundleName;
            _items = new List<ISalesItem>();
        }

        public void Add(ISalesItem item)
        {
            _items.Add(item);
        }

        public void Remove(ISalesItem item)
        {
            _items.Remove(item);
        }

        public void Display()
        {
            Console.WriteLine($"{_bundleName} Bundle:");
            foreach (var item in _items)
            {
                item.Display();
            }
        }

        public decimal GetPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in _items)
            {
                totalPrice += item.GetPrice();
            }
            return totalPrice;
        }
    }
}
