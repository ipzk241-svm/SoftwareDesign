using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.classes
{
	class ConnectionTypeHandler : SupportHandler
	{
		public override bool Handle()
		{
			Console.WriteLine("\n Оберіть тип підключення:");
			Console.WriteLine("1. Wi-Fi");
			Console.WriteLine("2. Кабельне з'єднання");
			Console.WriteLine("3. Мобільний інтернет");
			Console.Write("➡️ Ваш вибір: ");
			string? input = Console.ReadLine();

			if (input == "1" || input == "2" || input == "3")
			{
				return nextHandler?.Handle() ?? false;
			}

			Console.WriteLine(" Невірний вибір. Повторіть спробу.");
			return false;
		}
	}
}
