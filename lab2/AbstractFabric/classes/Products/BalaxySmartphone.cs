using AbstractFabric.interfaces;
using System;

namespace AbstractFabric.classes.Products
{
	internal class BalaxySmartphone : ISmartphone
	{
		public string Name { get; private set; }
		public string Model { get; private set; }
		public decimal Price { get; private set; }
		public DateTime ReleaseDate { get; private set; }

		public BalaxySmartphone(string name, string model, decimal price, DateTime releaseDate)
		{
			Name = name;
			Model = model;
			Price = price;
			ReleaseDate = releaseDate;
		}

		public BalaxySmartphone()
		{
			Name = "Opera";
			Model = "S0";
			Price = 150.99m;
			ReleaseDate = DateTime.Now;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Name: {Name}, Model: {Model}, Price: {Price}, Release Date: {ReleaseDate}");
		}
	}
}
