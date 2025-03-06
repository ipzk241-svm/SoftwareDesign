using Builder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.classes
{
	internal class Character : ICharacter
	{
		public string Name { get; set; }
		public double Height { get; set; }
		public string Build { get; set; }
		public string ActiveWeapon { get; set; }
		public string HairColor { get; set; }
		public string EyeColor { get; set; }
		public string Clothing { get; set; }
		public List<string> Inventory { get; set; } = new List<string>();
		public List<string> Deeds { get; set; } = new List<string>();

		public void DisplayInfo()
		{
			Console.WriteLine($"\nПерсонаж: {Name}");
			Console.WriteLine($"Зріст: {Height} см");
			Console.WriteLine($"Статура: {Build}");
			Console.WriteLine($"Активна зброя: {ActiveWeapon}");
			Console.WriteLine($"Колір волосся: {HairColor}");
			Console.WriteLine($"Колір очей: {EyeColor}");
			Console.WriteLine($"Одяг: {Clothing}");
			Console.WriteLine($"Інвентар: {string.Join(", ", Inventory)}");
			Console.WriteLine($"Діяння: {string.Join(", ", Deeds)}");
		}

		public void Attack(ICharacter character)
		{
			Console.WriteLine($"{Name} атакує {character.Name} використовуючи {ActiveWeapon}");
		}

		public void DoSomething(string something)
		{
			Console.WriteLine($"{Name}: {something}");
		}
	}
}
