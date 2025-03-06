using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.classes.Products
{
	internal class EppleLaptop : ILaptop
	{
		public string Name { get; private set; }
		public string Model { get; private set; }
		public decimal Price { get; private set; }
		public int RAM { get; private set; }
		public int Storage { get; private set; }
		public EppleLaptop()
		{
			Name = "EppleBook";
			Model = "pro";
			Price = 999.99m;
			RAM = 4;
			Storage = 128;
		}
		public EppleLaptop(string name, string model, decimal price, int ram, int storage)
		{
			Name = name;
			Model = model;
			Price = price;
			RAM = ram;
			Storage = storage;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Name: {Name}, Model: {Model}, Price: {Price}, RAM: {RAM}GB, Storage: {Storage}GB");
		}
	}
}
