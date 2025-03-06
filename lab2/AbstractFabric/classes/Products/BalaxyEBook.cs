using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.classes.Products
{
	internal class BalaxyEBook : IEBook
	{
		public string Model { get; set; }
		public int BatteryLife { get; set; }
		public string ScreenType { get; set; }

		public BalaxyEBook()
		{
			Model = "E1 model";
			BatteryLife = 10;
			ScreenType = "OLED";
		}
		public BalaxyEBook(string model, int batteryLife, string screenType)
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
