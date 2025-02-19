using lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
	internal class Reporter(IWarehouse warehouse) : IReporter
	{
		private readonly List<string> _incomeReports = new();
		private readonly List<string> _outcomeReports = new();

		private readonly IWarehouse warehouse = warehouse;

		public void RegisterIncome(IWarehouseItem item, int count, DateTime delivery)
		{
			_incomeReports.Add($"Income: {item.Product.Name}, Quantity: {count}, Date: {delivery}");
		}

		public void RegisterOutcome(IWarehouseItem item, int count, DateTime delivery)
		{
			_outcomeReports.Add($"Outcome: {item.Product.Name}, Quantity: {count}, Date: {delivery}");
		}

		public void ShowReports()
		{
			Console.WriteLine("\nIncome Reports:");
			foreach (var report in _incomeReports) Console.WriteLine(report);

			Console.WriteLine("\nOutcome Reports:");
			foreach (var report in _outcomeReports) Console.WriteLine(report);
		}

		public void Inventory()
		{
			Console.WriteLine("Inventory:");
			foreach (var item in warehouse.Items)
			{
				if (item.Product != null && item.Count > 0)
				{
					item.Display();
				}
			}
		}
	}
}
