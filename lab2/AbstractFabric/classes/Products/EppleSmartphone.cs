using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.classes.Products
{
	internal class EppleSmartphone : ISmartphone
	{
		public string Name { get; private set; }
		public string Model { get; private set; }
		public decimal Price { get; private set; }
		public DateTime ReleaseDate { get; private set; }

		public EppleSmartphone(string name, string model, decimal price, DateTime releaseDate)
		{
			Name = name;
			Model = model;
			Price = price;
			ReleaseDate = releaseDate;
		}

		public EppleSmartphone()
		{
			Name = "Peach";
			Model = "Ultra Super Pro";
			Price = 420.99m;
			ReleaseDate = DateTime.Now;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Name: {Name}, Model: {Model}, Price: {Price}, Release Date: {ReleaseDate}");
		}
	}
}
