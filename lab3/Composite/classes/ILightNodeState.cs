using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public interface ILightNodeState
	{
		string Render(LightNode node, int indentLevel);
		void HandleEvent(LightNode node, string eventType);
	}
}
