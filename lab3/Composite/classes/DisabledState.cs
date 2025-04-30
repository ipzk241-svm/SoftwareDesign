using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public class DisabledState : ILightNodeState
	{
		public string Render(LightNode node, int indentLevel = 0)
		{
			return string.Empty;
		}

		public void HandleEvent(LightNode node, string eventType)
		{
		}
	}


}
