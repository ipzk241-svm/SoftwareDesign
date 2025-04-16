﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public class LightElementNode : LightNode
	{
		private string _tagName;
		private bool _isBlock;
		private bool _isSelfClosing;
		private List<string> _cssClasses;
		private List<LightNode> _children;

		private Dictionary<string, List<Action>> _eventListeners = new Dictionary<string, List<Action>>();

		public LightElementNode(string tagName, bool isBlock, bool isSelfClosing, List<string> cssClasses = null)
		{
			_tagName = tagName;
			_isBlock = isBlock;
			_isSelfClosing = isSelfClosing;
			_cssClasses = cssClasses ?? new List<string>();
			_children = new List<LightNode>();
		}

		public void AddChild(LightNode child) => _children.Add(child);

		public void AddEventListener(string eventType, Action callback)
		{
			if (!_eventListeners.ContainsKey(eventType))
				_eventListeners[eventType] = new List<Action>();

			_eventListeners[eventType].Add(callback);
		}

		public void TriggerEvent(string eventType)
		{
			if (_eventListeners.TryGetValue(eventType, out var listeners))
			{
				foreach (var listener in listeners)
				{
					listener.Invoke();
				}
			}
		}

		public int ChildCount => _children.Count;

		public override string OuterHTML => BuildHTML(0);

		private string BuildHTML(int indentLevel)
		{
			StringBuilder sb = new StringBuilder();
			string classes = _cssClasses.Count > 0 ? $" class=\"{string.Join(" ", _cssClasses)}\"" : "";
			string indent = new string(' ', indentLevel * 2);

			if (_isSelfClosing)
			{
				sb.Append($"{indent}<{_tagName}{classes}/>");
			}
			else
			{
				sb.Append($"{indent}<{_tagName}{classes}>");

				if (_children.Count > 0 && _isBlock)
				{
					sb.Append("\n");
					foreach (var child in _children)
					{
						if (child is LightElementNode element)
							sb.Append(element.BuildHTML(indentLevel + 1));
						else
							sb.Append($"{new string(' ', (indentLevel + 1) * 2)}{child.OuterHTML}");
						sb.Append("\n");
					}
					sb.Append($"{indent}");
				}
				else
				{
					foreach (var child in _children)
						sb.Append(child.OuterHTML);
				}
				sb.Append($"</{_tagName}>");
			}
			return sb.ToString();
		}

		public override string InnerHTML => _isSelfClosing ? "" : BuildInnerHTML(0);

		private string BuildInnerHTML(int indentLevel)
		{
			StringBuilder sb = new StringBuilder();
			if (_children.Count > 0)
			{
				foreach (var child in _children)
				{
					if (_isBlock) sb.Append(new string(' ', indentLevel * 2));
					if (child is LightElementNode element)
						sb.Append(element.BuildHTML(indentLevel));
					else
						sb.Append(child.OuterHTML);
					if (_isBlock) sb.Append("\n");
				}
				if (_isBlock && sb.Length > 0) sb.Length--;
			}
			return sb.ToString();
		}
	}

}
