using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public abstract class LightNode
	{
		public abstract string OuterHTML { get; }
		public abstract string InnerHTML { get; }

		public virtual string RenderTemplate(int indentLevel = 0)
		{
			OnCreated();
			OnInserted();
			string content = RenderContent(indentLevel);
			OnTextRendered();
			return content;
		}

		protected virtual void OnCreated() { }
		protected virtual void OnInserted() { }
		protected virtual void OnRemoved() { }
		protected virtual void OnTextRendered() { }

		protected abstract string RenderContent(int indentLevel);

		public abstract void Accept(IVisitor visitor);
		public virtual string Render(int indentLevel = 0) => RenderTemplate(indentLevel);
	}

}
