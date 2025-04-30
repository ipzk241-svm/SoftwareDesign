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
			return node.RenderTemplate(indentLevel);
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
