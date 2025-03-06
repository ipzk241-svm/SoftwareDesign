using AbstractFabric.classes.Products;
using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFabric.interfaces.IEBook;

namespace AbstractFabric.classes.Factories
{
	internal class EppleFactory: IDeviceFactory
	{
		public ILaptop CreateLaptop() => new EppleLaptop();
		public INetbook CreateNetbook() => new EppleNetbook();
		public IEBook CreateEBook() => new EppleEBook();
		public ISmartphone CreateSmartphone() => new EppleSmartphone();
	}
}
