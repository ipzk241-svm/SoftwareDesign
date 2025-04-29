using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public class RemoveChildCommand : ICommand
	{
		private readonly LightElementNode _parent;
		private readonly LightNode _child;
		private int _index;

		public RemoveChildCommand(LightElementNode parent, LightNode child)
		{
			_parent = parent;
			_child = child;
		}

		public void Execute()
		{
			var children = _parent.GetChildren();
			_index = children.IndexOf(_child);
			if (_index != -1)
			{
				children.RemoveAt(_index);
			}
		}

		public void Undo()
		{
			var children = _parent.GetChildren();
			if (_index >= 0 && _index <= children.Count)
			{
				children.Insert(_index, _child);
			}
		}
	}

}
