using lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
	internal class ClothingProduct : Product
	{
		public string Size { get; private set; }
		public string Material { get; private set; }

		public ClothingProduct(string name, Money price, string description, string size, string material) : base(name, price, description)
		{
			Size = size;
			Material = material;
		}

		public override string ToString()
		{
			return base.ToString() + $", Size: {Size}";
		}
	}

}
