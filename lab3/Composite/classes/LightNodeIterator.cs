using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	using System.Collections.Generic;

	public class LightNodeIterator : Iterator
	{
		private readonly LightElementNode _element;
		private readonly List<LightNode> _children;
		private readonly bool _reverse;
		private int _position;

		public LightNodeIterator(LightElementNode element, bool reverse = false)
		{
			_element = element;
			_children = _element.GetChildren();
			_reverse = reverse;
			_position = reverse ? _children.Count : -1;
		}

		public override LightNode Current()
		{
			return _children[_position];
		}

		public override int Key()
		{
			return _position;
		}

		public override bool MoveNext()
		{
			int updatedPosition = _position + (_reverse ? -1 : 1);
			if (updatedPosition >= 0 && updatedPosition < _children.Count)
			{
				_position = updatedPosition;
				return true;
			}
			return false;
		}

		public override void Reset()
		{
			_position = _reverse ? _children.Count - 1 : 0;
		}
	}
}
