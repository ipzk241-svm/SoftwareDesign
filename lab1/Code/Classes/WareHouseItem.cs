using lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
	internal class WareHouseItem : IWarehouseItem
	{
		public Product _Product { get; protected set; }
		public int Count { get; protected set; }
		public DateTime LastDeliveryDate { get; set; }

		public WareHouseItem(Product product, int count, DateTime lastDeliveryDate)
		{
			_Product = product;
			Count = count;
			LastDeliveryDate = lastDeliveryDate;
		}

		public void ChangeCount(int count)
		{
			if(count < 0)
			{
				throw new ArgumentException("Count cannot be negative");
			}
			Count = count;
		}
		public void SetLastDeliveryDate(DateTime date)
		{
			if (date >= LastDeliveryDate)
			{
				LastDeliveryDate = date;
			} 
		}
		public void Display()
		{
			if (_Product != null)
			{
				Console.WriteLine(_Product.ToString() + ", Amount: " + Count);
			}
			else
			{
				Console.WriteLine("Product not available");
			}
		}
	}
}
