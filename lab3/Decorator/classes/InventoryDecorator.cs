using Decorator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.classes
{
	internal abstract class InventoryDecorator : IHero
	{
		protected IHero _hero;

		public InventoryDecorator(IHero hero)
		{
			_hero = hero;
		}

		public virtual string GetDescription() => _hero.GetDescription();
		public virtual int GetDamage() => _hero.GetDamage();
		public virtual int GetDefense() => _hero.GetDefense();
	}
}
