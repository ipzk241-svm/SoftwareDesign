using Composite.classes;

LightElementNode ul = new LightElementNode("ul", true, false, new List<string> { "shopping-list" });

LightElementNode li1 = new LightElementNode("li", true, false);
li1.AddChild(new Image("https://strategy.com/milk.jpg"));

LightElementNode li2 = new LightElementNode("li", true, false);
li2.AddChild(new Image("images/bread.jpg"));

LightElementNode li3 = new LightElementNode("li", true, false);
li3.AddChild(new Image("https://strategy.com/eggs.jpg"));

LightElementNode li4 = new LightElementNode("li", true, false);
LightElementNode nestedUl = new LightElementNode("ul", true, false, new List<string> { "nested" });
nestedUl.AddChild(new Image("https://strategy.com/apples.jpg"));
nestedUl.AddChild(new Image("images/oranges.jpg"));
li4.AddChild(nestedUl);

ul.AddChild(li1);
ul.AddChild(li2);
ul.AddChild(li3);
ul.AddChild(li4);

Console.WriteLine("Shopping List Example:");
Console.WriteLine("\nOuterHTML:");
Console.WriteLine(ul.OuterHTML);

Console.WriteLine("\nInnerHTML:");
Console.WriteLine(ul.InnerHTML);

Console.WriteLine($"\nNumber of children: {ul.ChildCount}");
