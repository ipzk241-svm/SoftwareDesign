using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public class AddChildCommand : ICommand
	{
		private readonly LightElementNode _parent;
		private readonly LightNode _child;

		public AddChildCommand(LightElementNode parent, LightNode child)
		{
			_parent = parent;
			_child = child;
		}

		public void Execute()
		{
			_parent.Add(_child);
		}

		public void Undo()
		{
			_parent.GetChildren().Remove(_child);
		}
	}

}
