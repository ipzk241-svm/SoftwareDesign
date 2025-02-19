using lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
	internal class Reporter : IReporter
	{
		public List<string> IncomeReports { get; private set; } = [];
		public List<string> OutcomeReports { get; private set; } = [];

		public IWarehouse Warehouse { get; } = null;

		public Reporter(IWarehouse warehouse)
		{
			this.Warehouse = warehouse;
		}
		public void RegisterIncome(IWarehouseItem item, int count, DateTime delivery)
		{
			IncomeReports.Add($"Income: {item._Product.Name}, Quantity: {count}, Date: {delivery}");
		}

		public void RegisterOutcome(IWarehouseItem item, int count, DateTime delivery)
		{
			OutcomeReports.Add($"Outcome: {item._Product.Name}, Quantity: {count}, Date: {delivery}");
		}

		public void ShowReports()
		{
			Console.WriteLine("\nIncome Reports:");
			foreach (var report in IncomeReports) Console.WriteLine(report);

			Console.WriteLine("\nOutcome Reports:");
			foreach (var report in OutcomeReports) Console.WriteLine(report);
		}

		public void Inventory()
		{
			Console.WriteLine("Inventory:");
			foreach (var item in Warehouse.Items)
			{
				if (item._Product != null && item.Count > 0)
				{
					item.Display();
				}
			}
		}
	}
}
