using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Interfaces
{
	internal interface IWarehouse
	{
		List<IWarehouseItem> Items { get; set; }
		void AddItem(IWarehouseItem item);
		void Display();
	}
}
