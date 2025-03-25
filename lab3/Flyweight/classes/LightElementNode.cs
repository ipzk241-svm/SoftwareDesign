using Flyweight.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.classes
{
	public class LightElementNode : LightNode
	{
		private HtmlElementFlyweight _flyweight;
		private List<LightNode> _children;

		public LightElementNode(HtmlElementFlyweight flyweight)
		{
			_flyweight = flyweight;
			_children = new List<LightNode>();
		}

		public void AddChild(LightNode child)
		{
			_children.Add(child);
		}

		public override string OuterHTML
		{
			get
			{
				return BuildHTML(0);
			}
		}

		private string BuildHTML(int indentLevel)
		{
			StringBuilder sb = new StringBuilder();
			string classes = _flyweight.CssClasses.Count > 0 ? $" class=\"{string.Join(" ", _flyweight.CssClasses)}\"" : "";
			string indent = new string(' ', indentLevel * 2);

			if (_flyweight.IsSelfClosing)
			{
				sb.Append($"{indent}<{_flyweight.TagName}{classes}/>");
			}
			else
			{
				sb.Append($"{indent}<{_flyweight.TagName}{classes}>");

				if (_children.Count > 0 && _flyweight.IsBlock)
				{
					sb.Append("\n");
					foreach (var child in _children)
					{
						if (child is LightElementNode element)
						{
							sb.Append(element.BuildHTML(indentLevel + 1));
						}
						else
						{
							sb.Append($"{new string(' ', (indentLevel + 1) * 2)}{child.OuterHTML}");
						}
						sb.Append("\n");
					}
					sb.Append($"{indent}");
				}
				else
				{
					foreach (var child in _children)
					{
						sb.Append(child.OuterHTML);
					}
				}

				sb.Append($"</{_flyweight.TagName}>");
			}

			return sb.ToString();
		}

		public override string InnerHTML
		{
			get
			{
				if (_flyweight.IsSelfClosing) return "";
				return BuildInnerHTML(0);
			}
		}

		private string BuildInnerHTML(int indentLevel)
		{
			StringBuilder sb = new StringBuilder();

			if (_children.Count > 0)
			{
				foreach (var child in _children)
				{
					if (_flyweight.IsBlock) sb.Append(new string(' ', indentLevel * 2));

					if (child is LightElementNode element)
					{
						sb.Append(element.BuildHTML(indentLevel));
					}
					else
					{
						sb.Append(child.OuterHTML);
					}

					if (_flyweight.IsBlock) sb.Append("\n");
				}

				if (_flyweight.IsBlock && sb.Length > 0)
				{
					sb.Length--;
				}
			}

			return sb.ToString();
		}
	}
}
