using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.interfaces
{
	interface ICharacter
	{
		public string Name { get; }
		public double Height { get; } 
		public string Build { get; } 
		public string HairColor { get; }
		public string ActiveWeapon { get; }
		public string EyeColor { get; }
		public string Clothing { get; }
		public List<string> Inventory { get; }
		public List<string> Deeds { get; }
		public void DisplayInfo();
		public void DoSomething(string something);
	}
}
