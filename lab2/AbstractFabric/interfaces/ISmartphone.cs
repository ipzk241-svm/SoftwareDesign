using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.interfaces
{
	internal interface ISmartphone
	{
		string Name { get; }
		string Model { get; }
		decimal Price { get; }
		DateTime ReleaseDate { get; }

		public void ShowInfo();
	}
}
