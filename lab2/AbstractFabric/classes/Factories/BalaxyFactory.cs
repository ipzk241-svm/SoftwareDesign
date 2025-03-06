using AbstractFabric.classes.Products;
using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.classes.Factories
{
	internal class BalaxyFactory: IDeviceFactory
	{
		public ILaptop CreateLaptop() => new BalaxyLaptop();
		public INetbook CreateNetbook() => new BalaxyNetbook();
		public IEBook CreateEBook() => new BalaxyEBook();
		public ISmartphone CreateSmartphone() => new BalaxySmartphone();
	}
}
