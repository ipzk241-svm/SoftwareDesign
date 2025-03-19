using Bridge.classes;
using Bridge.interfaces;

IRender vectorRenderer = new VectorRender();
IRender rasterRenderer = new RasterRender();

Shape[] shapes =
[
			new Circle(vectorRenderer),
			new Circle(rasterRenderer),
			new Square(vectorRenderer),
			new Square(rasterRenderer),
			new Triangle(vectorRenderer),
			new Triangle(rasterRenderer)
];

Console.WriteLine("Rendering shapes:");
foreach (var shape in shapes)
{
	shape.Draw();
}