using lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
	internal class FoodProduct : Product
	{
		public DateTime ExpirationDate { get; private set; } 

		public FoodProduct(string name, Money price, string description, DateTime expirationDate): base(name, price, description)
		{
			ExpirationDate = expirationDate;
		}

		public override string ToString()
		{
			return $"Food: {Name} - {Price}, Expires: {ExpirationDate.ToShortDateString()}, {Description}";
		}

	}

}
