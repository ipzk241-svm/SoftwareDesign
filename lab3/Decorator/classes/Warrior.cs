using Decorator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.classes
{
	internal class Warrior : IHero
	{
		public string GetDescription() => "Warrior";
		public int GetDamage() => 10;
		public int GetDefense() => 5;
	}
}
