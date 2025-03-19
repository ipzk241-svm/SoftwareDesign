using Decorator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.classes
{
	internal class Sword: InventoryDecorator
	{
		public Sword(IHero hero) : base(hero) { }

		public override string GetDescription() => $"{_hero.GetDescription()} with Sword";
		public override int GetDamage() => _hero.GetDamage() + 5;
	}
}
