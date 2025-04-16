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
		private Queue<TextDocument.Memento> _history = new();
		private const int _maxLength = 20;

		public void Start()
		{
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

				if (keyInfo.Key == ConsoleKey.Z && keyInfo.Modifiers.HasFlag(ConsoleModifiers.Control))
				{
					Undo();
				}
				else if (keyInfo.Key == ConsoleKey.Escape)
				{
					Console.WriteLine("🚪 Вихід з програми");
					break;
				}
				else if (keyInfo.Key == ConsoleKey.Backspace)
				{
					if (_document.GetContent().Length > 0)
					{
						Delete();
						Show();
					}
				}
				else if (keyInfo.Key == ConsoleKey.Enter)
				{
					Type("\n");
					Show();
				}
				else
				{

					Type(keyInfo.KeyChar.ToString());
					Show();
				}
			}
		}
		private void Type(string text)
		{
			if (_history.Count >= _maxLength)
			{
				_history.Dequeue();
			}
			_history.Enqueue(_document.Save());
			_document.Write(text);
		}

		private void Delete()
		{
			if (_history.Count >= _maxLength)
			{
				_history.Dequeue();
			}
			_history.Enqueue(_document.Save());
			_document.Delete();
		}

		private void Clear()
		{
			_history.Enqueue(_document.Save());
			_document.Erase();
		}

		private void Undo()
		{
			if (_history.Count > 0)
			{
				var last = _history.Last();
				_history = new Queue<TextDocument.Memento>(_history.Take(_history.Count - 1));
				_document.Restore(last);
				Show();
			}
		}

		private void Show()
		{
			Console.Clear();

			string content = _document.GetContent();
			Console.Write(content);

			int lines = content.Count(c => c == '\n');
			int lastLineLength = content.Split('\n').LastOrDefault()?.Length ?? 0;

			Console.SetCursorPosition(lastLineLength, lines);
		}
	}
}
