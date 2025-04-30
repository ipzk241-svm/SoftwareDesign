using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public class NodeCounterVisitor : IVisitor
	{
		public int ElementNodeCount { get; private set; }
		public int TextNodeCount { get; private set; }
		public int ImageNodeCount { get; private set; }

		public void Visit(LightElementNode elementNode)
		{
			ElementNodeCount++;
			foreach (var child in elementNode.GetChildren())
			{
				child.Accept(this);
			}
		}

		public void Visit(LightTextNode textNode)
		{
			TextNodeCount++;
		}

		public void Visit(Image imageNode)
		{
			ImageNodeCount++;
		}

		public string GetSummary()
		{
			return $"Element Nodes: {ElementNodeCount}, Text Nodes: {TextNodeCount}, Image Nodes: {ImageNodeCount}";
		}
	}
}
