using Decorator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.classes
{
	internal class Paladin : IHero
	{
		public string GetDescription() => "Paladin";
		public int GetDamage() => 8;
		public int GetDefense() => 8;
	}
}
