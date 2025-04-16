using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.classes
{
	class DetailMenuHandler : SupportHandler
	{
		public override bool Handle()
		{
			Console.WriteLine("\n Уточніть ситуацію:");
			Console.WriteLine("1. Повна відсутність сигналу");
			Console.WriteLine("2. Повільне з'єднання");
			Console.Write(" Ваш вибір: ");
			string? input = Console.ReadLine();

			if (input == "1")
			{
				Console.WriteLine(" Вас з’єднано з оператором першого рівня підтримки.");
				return true;
			}
			else if (input == "2")
			{
				return nextHandler?.Handle() ?? false;
			}

			Console.WriteLine(" Невірний вибір. Повторіть спробу.");
			return false;
		}
	}
}
