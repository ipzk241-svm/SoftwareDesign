using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.interfaces
{
	internal interface ICharacterBuilder
	{
		public ICharacterBuilder SetName(string name);
		public ICharacterBuilder SetHeight(double height);
		public ICharacterBuilder SetBuild(string build);
		public ICharacterBuilder SetHairColor(string hairColor);
		public ICharacterBuilder SetActiveWeapon(string activeWeapon);
		public ICharacterBuilder SetEyeColor(string eyeColor);
		public ICharacterBuilder SetClothing(string clothing);
		public ICharacterBuilder AddInventoryItem(string item);
		public ICharacterBuilder AddDeed(string deed);
		public ICharacter Build();
	}
}
