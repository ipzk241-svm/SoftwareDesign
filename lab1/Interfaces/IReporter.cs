using System;
using System.Collections.Generic;

namespace lab1.Interfaces
{
	internal interface IReporter
	{
		void RegisterIncome(IWarehouseItem item, int count, DateTime delivery);
		void RegisterOutcome(IWarehouseItem item, int count, DateTime delivery);
		void ShowReports();
		void Inventory();
	}
}
