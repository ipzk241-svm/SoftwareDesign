using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.interfaces
{
	internal interface INetbook
	{
		string Name { get; }
		string Processor { get; }
		int RAM { get; }
		int Storage { get; }
		double ScreenSize { get; }

		public void ShowInfo();
	}
}
