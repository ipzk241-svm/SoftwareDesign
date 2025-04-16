using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	public class TextEditor
	{
		private TextDocument _document = new TextDocument();
		private Stack<TextDocument.Memento> _history = new Stack<TextDocument.Memento>();

		public void Type(string text)
		{
			_history.Push(_document.Save());
			_document.Write(text);
		}

		public void Clear()
		{
			_history.Push(_document.Save());
			_document.Erase();
		}

		public void Undo()
		{
			if (_history.Count > 0)
			{
				var memento = _history.Pop();
				_document.Restore(memento);
			}
		}

		public void Show()
		{
			Console.WriteLine("%%% Current document content:");
			Console.WriteLine(_document.GetContent());
		}
	}
}
