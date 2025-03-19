using Decorator.classes;
using Decorator.interfaces;

IHero warrior = new Warrior();
Console.WriteLine("Basic Warrior:");
Console.WriteLine($"{warrior.GetDescription()} - Damage: {warrior.GetDamage()}, Defense: {warrior.GetDefense()}");

warrior = new Sword(warrior);
Console.WriteLine("\nWarrior with Sword:");
Console.WriteLine($"{warrior.GetDescription()} - Damage: {warrior.GetDamage()}, Defense: {warrior.GetDefense()}");

warrior = new ArmorPlate(new RingOfFire(warrior));
Console.WriteLine("\nFully equipped Warrior:");
Console.WriteLine($"{warrior.GetDescription()} - Damage: {warrior.GetDamage()}, Defense: {warrior.GetDefense()}");

// Те саме з магом
IHero mage = new Mage();
Console.WriteLine("\n\nBasic Mage:");
Console.WriteLine($"{mage.GetDescription()} - Damage: {mage.GetDamage()}, Defense: {mage.GetDefense()}");

mage = new RingOfFire(new Sword(mage));
Console.WriteLine("\nEquipped Mage:");
Console.WriteLine($"{mage.GetDescription()} - Damage: {mage.GetDamage()}, Defense: {mage.GetDefense()}");

// І з паладином
IHero paladin = new Paladin();
paladin = new ArmorPlate(new Sword(new RingOfFire(paladin)));
Console.WriteLine("\n\nFully equipped Paladin:");
Console.WriteLine($"{paladin.GetDescription()} - Damage: {paladin.GetDamage()}, Defense: {paladin.GetDefense()}");