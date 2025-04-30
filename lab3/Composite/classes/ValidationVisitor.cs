using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public class ValidationVisitor : IVisitor
	{
		private readonly List<string> _errors;
		private readonly HashSet<string> _ids;
		private readonly Stack<LightElementNode> _parentStack;

		public ValidationVisitor()
		{
			_errors = new List<string>();
			_ids = new HashSet<string>();
			_parentStack = new Stack<LightElementNode>();
		}

		public void Visit(LightElementNode elementNode)
		{
			string tagName = elementNode._tagName;
			bool isSelfClosing = elementNode._isSelfClosing;
			string id = elementNode._id;

			if (!string.IsNullOrEmpty(id))
			{
				if (_ids.Contains(id))
				{
					_errors.Add($"Duplicate ID '{id}' found in <{tagName}> element.");
				}
				else
				{
					_ids.Add(id);
				}
			}

			if (!isSelfClosing && elementNode.ChildCount == 0)
			{
				_errors.Add($"Element <{tagName}> is empty and not self-closing.");
			}

			if (tagName == "li")
			{
				bool hasValidParent = _parentStack.Any() &&
					  (_parentStack.Peek() as LightElementNode)?._tagName.ToLower() is "ul" or "ol";

				if (!hasValidParent)
				{
					_errors.Add($"<li> element is not nested within a <ul> or <ol> parent.");
				}
			}

			_parentStack.Push(elementNode);
			foreach (var child in elementNode.GetChildren())
			{
				child.Accept(this);
			}
			_parentStack.Pop();
		}

		public void Visit(LightTextNode textNode)
		{
			if (string.IsNullOrWhiteSpace(textNode.OuterHTML))
			{
				_errors.Add("Text node contains empty or whitespace content.");
			}
		}

		public void Visit(Image imageNode)
		{
			string id = imageNode.GetType().GetField("_id", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(imageNode)?.ToString() ?? "";
			if (!string.IsNullOrEmpty(id))
			{
				if (_ids.Contains(id))
				{
					_errors.Add($"Duplicate ID '{id}' found in <img> element with src='{imageNode.Href}'.");
				}
				else
				{
					_ids.Add(id);
				}
			}
		}

		public string GetValidationSummary()
		{
			if (_errors.Count == 0)
			{
				return "No validation errors found.";
			}
			return $"Found {_errors.Count} validation error(s):\n{string.Join("\n", _errors)}";
		}
	}
}
