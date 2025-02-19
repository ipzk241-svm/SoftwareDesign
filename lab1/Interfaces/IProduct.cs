using lab1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Interfaces
{
	internal interface IProduct
	{
		string Name { get; set; }
		Money Price { get; set; }
		string Description { get; set; }
		void Display();
		void DecreasePrice(decimal price);
		string ToString();
	}
}
