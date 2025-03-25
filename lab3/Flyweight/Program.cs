using Composite.classes;
using Flyweight.classes;
using LightElementNode = Flyweight.classes.LightElementNode;

FlyweightFactory factory = new FlyweightFactory();
var lines = File.ReadAllLines("D:/Study/Politech/24-25/2 semester/KPZ/SoftwareDesign/lab3/Flyweight/book.txt");

Console.WriteLine("Without Flyweight:");
LightElementNode bodyOld = new LightElementNode(new HtmlElementFlyweight("body", true, false));
foreach (var line in lines)
{
	LightElementNode element;
	if (lines.ToList().IndexOf(line) == 0)
	{
		element = new LightElementNode(new HtmlElementFlyweight("h1", true, false));
	}
	else if (line.Length < 20)
	{
		element = new LightElementNode(new HtmlElementFlyweight("h2", true, false));
	}
	else if (line.StartsWith(" "))
	{
		element = new LightElementNode(new HtmlElementFlyweight("blockquote", true, false));
	}
	else
	{
		element = new LightElementNode(new HtmlElementFlyweight("p", true, false));
	}
	element.AddChild(new LightTextNode(line.Trim()));
	bodyOld.AddChild(element);
}

Console.WriteLine(bodyOld.OuterHTML);
long memoryBefore = GC.GetTotalMemory(true);

//Console.WriteLine("\nWith Flyweight:");
//LightElementNode bodyNew = new LightElementNode(factory.GetFlyweight("body", true, false));
//foreach (var line in lines)
//{
//	LightElementNode element;
//	if (lines.ToList().IndexOf(line) == 0)
//	{
//		element = new LightElementNode(factory.GetFlyweight("h1", true, false));
//	}
//	else if (line.Length < 20)
//	{
//		element = new LightElementNode(factory.GetFlyweight("h2", true, false));
//	}
//	else if (line.StartsWith(" "))
//	{
//		element = new LightElementNode(factory.GetFlyweight("blockquote", true, false));
//	}
//	else
//	{
//		element = new LightElementNode(factory.GetFlyweight("p", true, false));
//	}
//	element.AddChild(new LightTextNode(line.Trim()));
//	bodyNew.AddChild(element);
//}

//Console.WriteLine(bodyNew.OuterHTML);
//long memoryAfter = GC.GetTotalMemory(true);
Console.WriteLine($"\nMemory used without Flyweight: {memoryBefore} bytes");
//Console.WriteLine($"Memory used with Flyweight: {memoryAfter} bytes");
//Console.WriteLine($"Flyweights created: {factory.FlyweightCount}");
