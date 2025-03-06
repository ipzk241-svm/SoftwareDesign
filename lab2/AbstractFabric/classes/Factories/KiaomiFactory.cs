using AbstractFabric.classes.Products;
using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.classes.Factories
{
	internal class KiaomiFactory: IDeviceFactory
	{
		public ILaptop CreateLaptop() => new KiaomiLaptop();
		public INetbook CreateNetbook() => new KiaomiNetbook();
		public IEBook CreateEBook() => new KiaomiEBook();
		public ISmartphone CreateSmartphone() => new KiaomiSmartphone();
	}
}
