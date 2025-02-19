using lab1.Classes;
using System;

class Program
{
	static void Main(string[] args)
	{
		Product product1 = new ClothingProduct("Shirt", new Money(10, "USD"), "A nice shirt", "M", "Cotton");
		Product product2 = new ClothingProduct("Pants", new Money(20, "USD"), "A nice pair of pants", "L", "Denim");
		Product product3 = new FoodProduct("Apple", new Money(1, "USD"), "A delicious apple", DateTime.Now.AddDays(7));
		Product product4 = new FoodProduct("Banana", new Money(2, "USD"), "A delicious banana", DateTime.Now.AddDays(5));

		WareHouseItem item1 = new WareHouseItem(product1, 10, DateTime.Now);
		WareHouseItem item2 = new WareHouseItem(product2, 20, DateTime.Now);
		WareHouseItem item3 = new WareHouseItem(product3, 50, DateTime.Now);
		WareHouseItem item4 = new WareHouseItem(product4, 60, DateTime.Now);

		Warehouse warehouse = new Warehouse();
		warehouse.AddItem(item1);
		warehouse.AddItem(item2);
		warehouse.AddItem(item3);
		warehouse.AddItem(item4);

		Console.WriteLine("Warehouse Inventory:");
		warehouse.Display();

		warehouse.AddItem(new WareHouseItem(product1, 4, DateTime.Now));
		warehouse.RemoveItem(item2);

		Console.WriteLine("\nWarehouse Inventory after removal:");
		warehouse.Display();

		warehouse.reporter.ShowReports();

		Console.WriteLine("\nPerforming Inventory:");
		warehouse.reporter.Inventory();
	}
}
