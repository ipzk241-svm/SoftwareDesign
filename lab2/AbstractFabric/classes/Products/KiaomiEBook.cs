using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.classes.Products
{
	internal class KiaomiEBook : IEBook
	{
		public string Model { get; set; }
		public int BatteryLife { get; set; }
		public string ScreenType { get; set; }

		public KiaomiEBook()
		{
			Model = "Kiaomi Ebook";
			BatteryLife = 10;
			ScreenType = "IPS";
		}
		public KiaomiEBook(string model, int batteryLife, string screenType)
		{
			Model = model;
			BatteryLife = batteryLife;
			ScreenType = screenType;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Model: {Model}, Battery Life: {BatteryLife} hours, Screen Type: {ScreenType}");
		}
	}
}
