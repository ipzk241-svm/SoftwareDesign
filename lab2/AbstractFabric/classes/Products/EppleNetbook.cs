using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.classes.Products
{
	internal class EppleNetbook : INetbook
	{
		public string Name { get; private set; }
		public string Processor { get; private set; }
		public int RAM { get; private set; }
		public int Storage { get; private set; }
		public double ScreenSize { get; private set; }

		public EppleNetbook()
		{
			Name = "Epple Netbook";
			Processor = "Ryzen 5 5600";
			RAM = 32;
			Storage = 256;
			ScreenSize = 13.3;
		}
		public EppleNetbook(string name, string processor, int ram, int storage, double screenSize)
		{
			Name = name;
			Processor = processor;
			RAM = ram;
			Storage = storage;
			ScreenSize = screenSize;
		}
		public void ShowInfo()
		{
			Console.WriteLine($"Name: {Name}, Processor: {Processor}, RAM: {RAM} GB, Storage: {Storage} GB, Screen Size: {ScreenSize} inches");

		}
	}
}
