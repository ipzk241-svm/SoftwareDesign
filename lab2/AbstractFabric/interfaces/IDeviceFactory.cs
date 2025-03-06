using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFabric.interfaces.IEBook;

namespace AbstractFabric.interfaces
{
	internal interface IDeviceFactory
	{
		public ILaptop CreateLaptop();
		public INetbook CreateNetbook();
		public IEBook CreateEBook();
		public ISmartphone CreateSmartphone();
	}
}
