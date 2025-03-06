using Prototype;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Virus grandparent = new Virus("Virus1.1", 20, 1.5f, "Type1");

Virus parent1 = new Virus("Virus2.1", 20, 1.5f, "Type2");
Virus parent2 = new Virus("Virus2.2", 20, 1.5f, "Type2");
grandparent.AddChild(parent1);
grandparent.AddChild(parent2);

Virus child1 = new Virus("Virus3.1", 20, 1.5f, "Type3");
Virus child2 = new Virus("Virus3.2", 20, 1.5f, "Type3");
Virus child3 = new Virus("Virus3.3", 20, 1.5f, "Type3");
parent1.AddChild(child1); 
parent1.AddChild(child2);
parent2.AddChild(child3);

Console.WriteLine("Оригінальне сімейство вірусів:");
grandparent.DisplayInfo();

Virus clonedFamily = (Virus)grandparent.Clone();

Console.WriteLine("\nКлоноване сімейство вірусів:");
clonedFamily.DisplayInfo();

clonedFamily.Name = "cloneVirus1.1";
clonedFamily.Childs[0].Name = "cloneVirus2.1-new";
clonedFamily.Childs[1].Name = "cloneVirus2.2-new";
clonedFamily.Name = "NewName";

Console.WriteLine("\nОригінальне сімейство вірусів (після змін у клонованому):");
grandparent.DisplayInfo();
Console.WriteLine("\nКлоноване сімейство вірусів (після змін у клонованому):");
clonedFamily.DisplayInfo();