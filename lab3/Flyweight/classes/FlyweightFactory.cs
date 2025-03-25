using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.classes
{
	internal class FlyweightFactory
	{
		private Dictionary<string, HtmlElementFlyweight> _flyweights = new Dictionary<string, HtmlElementFlyweight>();

		public HtmlElementFlyweight GetFlyweight(string tagName, bool isBlock, bool isSelfClosing, List<string> cssClasses = null)
		{
			string key = $"{tagName}_{isBlock}_{isSelfClosing}_{string.Join(",", cssClasses ?? new List<string>())}";

			if (!_flyweights.ContainsKey(key))
			{
				_flyweights[key] = new HtmlElementFlyweight(tagName, isBlock, isSelfClosing, cssClasses);
			}

			return _flyweights[key];
		}

		public int FlyweightCount => _flyweights.Count;
	}
}
