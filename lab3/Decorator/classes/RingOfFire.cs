using Decorator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.classes
{
	internal class RingOfFire : InventoryDecorator
	{
		public RingOfFire(IHero hero) : base(hero) { }

		public override string GetDescription() => $"{_hero.GetDescription()} with Ring of fire";
		public override int GetDamage() => _hero.GetDamage() + 5;
		public override int GetDefense() => _hero.GetDefense() + 1;
	}
}
