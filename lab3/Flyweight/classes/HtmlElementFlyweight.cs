using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.classes
{
	public class HtmlElementFlyweight
	{
		public string TagName { get; }
		public bool IsBlock { get; }
		public bool IsSelfClosing { get; }
		public List<string> CssClasses { get; }

		public HtmlElementFlyweight(string tagName, bool isBlock, bool isSelfClosing, List<string> cssClasses = null)
		{
			TagName = tagName;
			IsBlock = isBlock;
			IsSelfClosing = isSelfClosing;
			CssClasses = cssClasses ?? new List<string>();
		}
	}
}
