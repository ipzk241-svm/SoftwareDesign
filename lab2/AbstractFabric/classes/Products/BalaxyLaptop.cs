using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.classes.Products
{
	internal class BalaxyLaptop: ILaptop
	{
		public string Name { get; private set; }
		public string Model { get; private set; }
		public decimal Price { get; private set; }
		public int RAM { get; private set; }
		public int Storage { get; private set; }
		public BalaxyLaptop()
		{
			Name = "Balaxy Laptop";
			Model = "Arch4";
			Price = 450.0m;
			RAM = 4;
			Storage = 128;
		}
		public BalaxyLaptop(string name, string model, decimal price, int ram, int storage)
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
