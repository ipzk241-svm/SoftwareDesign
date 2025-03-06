using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.classes.Products
{
	internal class EppleEBook : IEBook
	{
		public string Model { get; set; }
		public int BatteryLife { get; set; }
		public string ScreenType { get; set; }

		public EppleEBook()
		{
			Model = "Epple Fly";
			BatteryLife = 10;
			ScreenType = "IPS";
		}
		public EppleEBook(string model, int batteryLife, string screenType)
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
