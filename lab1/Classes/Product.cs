using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Interfaces;

namespace lab1.Classes
{
	public abstract class Product
	{
		public string Name { get; set; }
		public Money Price { get; set; }
		public string Description { get; set; }
		public Product(string name, Money price, string description)
		{
			Name = name;
			Price = price;
			Description = description;
		}
		public void Display()
		{
			Console.WriteLine(ToString());
		}
		public override string ToString()
		{
			return $"Product: {Name}, Price: {Price}, Description: {Description}";
		}

		public void DecreasePrice(decimal price)
		{
			Money money = new Money(price, Price.Currency);
			Price -= money;
		}
	}
}
