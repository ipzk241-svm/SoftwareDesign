using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.interfaces
{
	internal interface ILaptop
	{
		string Name { get; }
		string Model { get; }
		decimal Price { get; }
		int RAM { get; }
		int Storage { get; }

		public void ShowInfo();
	}
}
