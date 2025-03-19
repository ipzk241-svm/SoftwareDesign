using Decorator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.classes
{
	internal class Mage : IHero
	{
		public string GetDescription() => "Mage";
		public int GetDamage() => 15;
		public int GetDefense() => 2;
	}
}
