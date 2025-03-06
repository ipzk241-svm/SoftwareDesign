﻿using Builder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.classes
{
	internal class CharacterDirector
	{

		public ICharacter NoobHero(ICharacterBuilder builder)
		{
			return builder
				.SetName("Пригодник")
				.SetHeight(172)
				.SetBuild("Стрункий")
				.SetHairColor("Коричневий")
				.SetEyeColor("Синій")
				.SetClothing("Базова броня")
				.SetActiveWeapon("Палка")
				.AddInventoryItem("Дерев'яний меч")
				.AddInventoryItem("Зілля здоров'я")
				.AddDeed("Врятував курку від лисиці")
				.Build();
		}
		public ICharacter ProHero(ICharacterBuilder builder)
		{
			return builder
				.SetName("Супер Рицар")
				.SetHeight(188)
				.SetBuild("Мускулистий")
				.SetHairColor("Чорний")
				.SetEyeColor("Зелений")
				.SetClothing("Елітна броня")
				.SetActiveWeapon("Меч ворона")
				.AddInventoryItem("Магічний меч")
				.AddInventoryItem("Зілля сили")
				.AddInventoryItem("Щит дракона")
				.AddDeed("Переміг дракона")
				.AddDeed("Врятував королівство")
				.AddDeed("Почав розводити курей")
				.AddDeed("Знайшов скарб")
				.Build();
		}
		public ICharacter MobEnemy(ICharacterBuilder builder)
		{
			return builder
				.SetName("Гоблін")
				.SetHeight(155)
				.SetBuild("Середній")
				.SetHairColor("Сірий")
				.SetEyeColor("Червоний")
				.SetClothing("Проста броня")
				.SetActiveWeapon("Звичайний меч")
				.AddInventoryItem("Звичайний меч")
				.AddInventoryItem("Зілля здоров'я")
				.AddDeed("Вдарив курку")
				.Build();
		}
		public ICharacter BossEnemy(ICharacterBuilder builder)
		{
			return builder
				.SetName("Бос")
				.SetHeight(200)
				.SetBuild("Гігантський")
				.SetHairColor("Чорний")
				.SetEyeColor("Червоний")
				.SetClothing("Магічна броня")
				.SetActiveWeapon("Меч зла")
				.AddInventoryItem("Меч зла")
				.AddInventoryItem("Зілля безсмертя")
				.AddInventoryItem("Щит темряви")
				.AddDeed("Знищив село")
				.AddDeed("Вдарив 2 курки")
				.AddDeed("Спалив курятник")
				.Build();
		}
	}
}
