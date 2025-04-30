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

		public override string Render(int indentLevel = 0)
		{
			return RenderTemplate(indentLevel);
		}

		protected override string RenderContent(int indentLevel)
		{
			OnTextRendered();
			string indent = new string(' ', indentLevel * 2);
			return indent + _text;
		}

		protected override void OnCreated()
		{
			Console.WriteLine("Text Node created.");
		}

		protected override void OnInserted()
		{
			Console.WriteLine("Text Node inserted.");
		}

		protected override void OnRemoved()
		{
			Console.WriteLine("Text Node removed.");
		}

		protected override void OnTextRendered()
		{
			Console.WriteLine("Text Node rendered.");
		}

		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
