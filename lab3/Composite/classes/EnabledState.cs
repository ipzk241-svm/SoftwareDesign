using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public class EnabledState : ILightNodeState
	{
		public string Render(LightNode node, int indentLevel = 0)
		{
			if (node is LightElementNode element)
			{
				return element.BuildHTML(indentLevel);
			}
			else
			{
				return node.OuterHTML;
			}
		}

		public void HandleEvent(LightNode node, string eventType)
		{
			if (node is LightElementNode element)
			{
				element.TriggerEvent(eventType);
			}
		}
	}

}
