using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.classes
{
	class TechnicalMenuHandler : SupportHandler
	{
		public override bool Handle()
		{
			Console.WriteLine("\n Оберіть тип технічної проблеми:");
			Console.WriteLine("1. Інтернет не працює");
			Console.WriteLine("2. Проблема з роутером");
			Console.Write("➡️ Ваш вибір: ");
			string? input = Console.ReadLine();

			if (input == "1" || input == "2")
			{
				return nextHandler?.Handle() ?? false;
			}

			Console.WriteLine(" Невірний вибір. Повторіть спробу.");
			return false;
		}
	}
}
