using Bridge.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.classes
{
	internal class Circle : Shape
	{
		public Circle(IRender renderer) : base(renderer) { }

		public override void Draw()
		{
			_renderer.RenderShape("Circle");
		}
	}
}
