using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.classes
{
	class FinalSupportHandler : SupportHandler
	{
		public override bool Handle()
		{
			Console.WriteLine("\n Поглиблений аналіз проблеми:");
			Console.WriteLine("1. Проблема постійна");
			Console.WriteLine("2. Виникає лише у певний час");
			Console.Write("➡️ Ваш вибір: ");
			string? input = Console.ReadLine();

			if (input == "1" || input == "2")
			{
				Console.WriteLine(" Вас з’єднано з експертом технічної підтримки.");
				return true;
			}

			Console.WriteLine(" Невірний вибір. Повторіть спробу.");
			return false;
		}
	}
}
