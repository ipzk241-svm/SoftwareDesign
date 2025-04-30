using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public abstract class LightNode : IVisitable
	{
		public abstract string OuterHTML { get; }
		public abstract string InnerHTML { get; }

		public virtual string Render(int indentLevel = 0)
		{
			return OuterHTML; 
		}
		public abstract void Accept(IVisitor visitor);
	}
}
