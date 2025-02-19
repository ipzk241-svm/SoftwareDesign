using lab1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Interfaces
{
	public interface IMoney
	{
		int Whole { get; }
		int Fraction { get; }
		CurrencyType Currency { get; }
		decimal GetAmount();
		void Display();
	}
}
