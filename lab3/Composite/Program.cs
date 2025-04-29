using Composite.classes;

LightElementNode ul = new LightElementNode("ul", true, false);

// Перший <li> з простим текстом
LightElementNode li1 = new LightElementNode("li", true, false);
li1.AddChild(new LightTextNode("Item 1"));
ul.AddChild(li1);

// Другий <li> з вкладеним <span>
LightElementNode li2 = new LightElementNode("li", true, false);
li2.AddChild(new LightTextNode("Item 2 "));
LightElementNode span = new LightElementNode("span", false, false);
span.AddChild(new LightTextNode("(with span)"));
li2.AddChild(span);
ul.AddChild(li2);

// Третій <li> з вкладеним <strong>
LightElementNode li3 = new LightElementNode("li", true, false);
li3.AddChild(new LightTextNode("Item 3 "));
LightElementNode strong = new LightElementNode("strong", false, false);
strong.AddChild(new LightTextNode("important"));
li3.AddChild(strong);
ul.AddChild(li3);

Console.WriteLine("➡ Прямий обхід:");
foreach (LightNode child in ul)
{
	Console.WriteLine(child.OuterHTML);
}

ul.ReverseDirection();

Console.WriteLine("\n⬅ Зворотній обхід:");
foreach (LightNode child in ul)
{
	Console.WriteLine(child.OuterHTML);
}
