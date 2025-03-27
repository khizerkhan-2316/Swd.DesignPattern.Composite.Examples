using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.DesignPattern.Composite.Examples.SalesSimpleExample.Interfaces
{
    public interface ISalesItem
    {
        decimal GetPrice();
        void Display();
    }
}
