using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.DesignPattern.Composite.Examples.Sales.Interfaces
{
	public interface ISubject
	{
		void Attach(IObserver observer);
		void Detach(IObserver observer);
		void Notify();

	}
}
