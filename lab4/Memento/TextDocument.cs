using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	public class TextDocument
	{
		private string _content = "";

		public void Write(string text)
		{
			_content += text;
		}

		public void Erase()
		{
			_content = "";
		}

		public string GetContent()
		{
			return _content;
		}

		public Memento Save()
		{
			return new Memento(_content);
		}

		public void Restore(Memento memento)
		{
			_content = memento._state;
		}

		public class Memento
		{
			internal string _state;

			internal Memento(string state)
			{
				_state = state;
			}
		}
	}
}
