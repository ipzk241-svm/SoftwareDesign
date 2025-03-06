using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.classes.Products
{
	internal class KiaomiLaptop : ILaptop
	{
		public string Name { get; private set; }
		public string Model { get; private set; }
		public decimal Price { get; private set; }
		public int RAM { get; private set; }
		public int Storage { get; private set; }

		public KiaomiLaptop(string name, string model, decimal price, int ram, int storage)
		{
			Name = name;
			Model = model;
			Price = price;
			RAM = ram;
			Storage = storage;
		}
		public KiaomiLaptop()
		{
			Name = "Kiaomi Laptop";
			Model = "pro";
			Price = 249.99m;
			RAM = 16;
			Storage = 512;
		}
		public void ShowInfo()
		{
			Console.WriteLine($"Name: {Name}, Model: {Model}, Price: {Price}, RAM: {RAM}GB, Storage: {Storage}GB");
		}
	}
}
