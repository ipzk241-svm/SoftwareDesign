using Composite.classes;

var button = new LightElementNode("button", isBlock: false, isSelfClosing: false, new List<string> { "btn", "btn-primary" });
button.AddChild(new LightTextNode("Click Me"));

button.AddEventListener("click", () => Console.WriteLine("Button clicked!"));
button.AddEventListener("mouseover", () => Console.WriteLine("Mouse over button!"));

Console.WriteLine("== HTML Output ==");
Console.WriteLine(button.OuterHTML);

Console.WriteLine("\n== Simulating events ==");
button.TriggerEvent("click");
button.TriggerEvent("mouseover");

button.TriggerEvent("keydown");