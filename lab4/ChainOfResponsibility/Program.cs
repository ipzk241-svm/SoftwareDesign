using ChainOfResponsibility.classes;
using System.Text;

class Program
{
	static void Main()
	{
		Console.OutputEncoding = Encoding.UTF8;

		var main = new MainMenuHandler();
		var tech = new TechnicalMenuHandler();
		var conn = new ConnectionTypeHandler();
		var detail = new DetailMenuHandler();
		var expert = new FinalSupportHandler();

		main.SetNext(tech).SetNext(conn).SetNext(detail).SetNext(expert);

		bool resolved = false;
		while (!resolved)
		{
			resolved = main.Handle();

			if (!resolved)
			{
				Console.WriteLine("\nПовертаємося до початку...\n");
			}
		}
	}
}
