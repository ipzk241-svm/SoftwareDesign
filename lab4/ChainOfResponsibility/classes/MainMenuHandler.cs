using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.classes
{
	class MainMenuHandler : SupportHandler
	{
		public override bool Handle()
		{
			Console.WriteLine("\n Вітаємо у службі підтримки!");
			Console.WriteLine("1. Технічна підтримка");
			Console.WriteLine("2. Фінансові питання");
			Console.Write(" Виберіть розділ: ");
			string? input = Console.ReadLine();

			if (input == "1")
			{
				return nextHandler?.Handle() ?? false;
			}
			else if (input == "2")
			{
				Console.WriteLine(" Вас з’єднано з фінансовим спеціалістом.");
				return true;
			}

			Console.WriteLine(" Невірний вибір. Повторіть спробу.");
			return false;
		}
	}
}
