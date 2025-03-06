using Builder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.classes
{
	internal class HeroBuilder: ICharacterBuilder
	{
		private Character _hero;

		public HeroBuilder()
		{
			_hero = new Character();
		}

		private void Reset()
		{
			_hero = new Character();
		}

		public ICharacterBuilder SetName(string name)
		{
			_hero.Name = name;
			return this;
		}

		public ICharacterBuilder SetHeight(double height)
		{
			_hero.Height = height;
			return this;
		}

		public ICharacterBuilder SetBuild(string build)
		{
			_hero.Build = build;
			return this;
		}

		public ICharacterBuilder SetHairColor(string hairColor)
		{
			_hero.HairColor = hairColor;
			return this;
		}

		public ICharacterBuilder SetEyeColor(string eyeColor)
		{
			_hero.EyeColor = eyeColor;
			return this;
		}

		public ICharacterBuilder SetClothing(string clothing)
		{
			_hero.Clothing = clothing;
			return this;
		}
		public ICharacterBuilder SetActiveWeapon(string activeWeapon)
		{
			_hero.ActiveWeapon = activeWeapon;
			return this;
		}
		public ICharacterBuilder AddInventoryItem(string item)
		{
			_hero.Inventory.Add(item);
			return this;
		}

		public ICharacterBuilder AddDeed(string deed)
		{
			_hero.Deeds.Add($"Добре діло: {deed}");
			return this;
		}

		public ICharacter Build()
		{
			var newHero = _hero;
			Reset();
			return newHero;
		}

	}
}
