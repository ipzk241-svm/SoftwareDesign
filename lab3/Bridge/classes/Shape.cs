using Bridge.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.classes
{
	public abstract class Shape
	{
		protected IRender _renderer;

		public Shape(IRender renderer)
		{
			_renderer = renderer;
		}

		public abstract void Draw();
	}
}
