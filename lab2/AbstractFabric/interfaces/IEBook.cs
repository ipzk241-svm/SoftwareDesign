using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.interfaces
{
	internal interface IEBook
	{
		string Model { get; set; }
		int BatteryLife { get; set; }
		string ScreenType { get; set; }

		void ShowInfo();
	}
}
