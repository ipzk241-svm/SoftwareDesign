using Decorator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.classes
{
	internal class ArmorPlate : InventoryDecorator
	{
		public ArmorPlate(IHero hero) : base(hero) { }

		public override string GetDescription() => $"{_hero.GetDescription()} with Armor plate";
		public override int GetDefense() => _hero.GetDefense() + 4;
	}
}
