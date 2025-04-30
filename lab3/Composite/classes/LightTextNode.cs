using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public class LightTextNode : LightNode
	{
		private string _text;

		public LightTextNode(string text)
		{
			_text = text;
		}

		public override string OuterHTML => _text;
		public override string InnerHTML => _text;

		public string Render()
		{
			return OuterHTML;
		}

		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
