using Builder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.classes
{
	internal class EnemyBuilder : ICharacterBuilder
	{
		private ICharacter _enemy;

		public EnemyBuilder()
		{
			_enemy = new ICharacter();
		}
		private void Reset()
		{
			_enemy = new ICharacter();
		}
		public ICharacterBuilder SetName(string name)
		{
			_enemy.Name = name;
			return this;
		}

		public ICharacterBuilder SetHeight(double height)
		{
			_enemy.Height = height;
			return this;
		}

		public ICharacterBuilder SetBuild(string build)
		{
			_enemy.Build = build;
			return this;
		}

		public ICharacterBuilder SetHairColor(string hairColor)
		{
			_enemy.HairColor = hairColor;
			return this;
		}

		public ICharacterBuilder SetEyeColor(string eyeColor)
		{
			_enemy.EyeColor = eyeColor;
			return this;
		}
		public ICharacterBuilder SetActiveWeapon(string activeWeapon)
		{
			_enemy.ActiveWeapon = activeWeapon;
			return this;
		}
		public ICharacterBuilder SetClothing(string clothing)
		{
			_enemy.Clothing = clothing;
			return this;
		}

		public ICharacterBuilder AddInventoryItem(string item)
		{
			_enemy.Inventory.Add(item);
			return this;
		}

		public ICharacterBuilder AddDeed(string deed)
		{
			_enemy.Deeds.Add($"Зле діло: {deed}");
			return this;
		}

		public ICharacter Build()
		{
			var newEnemy = _enemy;
			Reset();
			return newEnemy;
		}
	}
}
