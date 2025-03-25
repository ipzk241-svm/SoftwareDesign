using Composite.classes;

LightElementNode ul = new LightElementNode("ul", true, false, new List<string> { "shopping-list" });

// Додаємо елементи списку
LightElementNode li1 = new LightElementNode("li", true, false);
li1.AddChild(new LightTextNode("Milk"));

LightElementNode li2 = new LightElementNode("li", true, false);
li2.AddChild(new LightTextNode("Bread"));

LightElementNode li3 = new LightElementNode("li", true, false);
li3.AddChild(new LightTextNode("Eggs"));

// Додаємо вкладений список
LightElementNode li4 = new LightElementNode("li", true, false);
LightElementNode nestedUl = new LightElementNode("ul", true, false, new List<string> { "nested" });
nestedUl.AddChild(new LightTextNode("Apples"));
nestedUl.AddChild(new LightTextNode("Oranges"));
li4.AddChild(nestedUl);

// Додаємо всі li до ul
ul.AddChild(li1);
ul.AddChild(li2);
ul.AddChild(li3);
ul.AddChild(li4);

// Виводимо результати
Console.WriteLine("Shopping List Example:");
Console.WriteLine("\nOuterHTML:");
Console.WriteLine(ul.OuterHTML);

Console.WriteLine("\nInnerHTML:");
Console.WriteLine(ul.InnerHTML);

Console.WriteLine($"\nNumber of children: {ul.ChildCount}");