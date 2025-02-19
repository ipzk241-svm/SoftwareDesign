using lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
	internal class Warehouse : IWarehouse
	{
		public List<IWarehouseItem> Items { get; set; } = new List<IWarehouseItem>();
		public Reporter reporter;

		public Warehouse()
		{
			reporter = new(this);
		}
		public void AddItem(IWarehouseItem item)
		{
			var existingItem = Items.FirstOrDefault(i => i.Product.Name == item.Product.Name);
			if (existingItem != null)
			{
				existingItem.ChangeCount(existingItem.Count + item.Count);
				existingItem.SetLastDeliveryDate(DateTime.Now);
			}
			else
			{
				Items.Add(item);
			}
			reporter.RegisterIncome(item, item.Count, DateTime.Now);
		}
		public void RemoveItem(IWarehouseItem item)
		{
			var existingItem = Items.FirstOrDefault(i => i.Product.Name == item.Product.Name);
			if (existingItem != null)
			{
				reporter.RegisterOutcome(item, item.Count, DateTime.Now);
				if (existingItem.Count > item.Count)
				{
					existingItem.ChangeCount(existingItem.Count - item.Count);
				}
				else
				{
					existingItem.ChangeCount(0);
				}
			}
		}
		public void Display()
		{
			foreach (IWarehouseItem item in Items)
			{
				item.Display();
			}
		}
	}
}
