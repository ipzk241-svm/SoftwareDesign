using lab1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Interfaces
{
	internal interface IWarehouseItem
	{
		Product _Product { get; }
		int Count { get; }
		DateTime LastDeliveryDate { get; }
		void ChangeCount(int newCount);
		void SetLastDeliveryDate(DateTime date);
		void Display();
	}
}
