using Proxy.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy.classes
{
	internal class SmartTextReaderLocker : ISmartTextReader
	{
		private SmartTextReader _reader;
		private string _pattern;

		public SmartTextReaderLocker(string pattern)
		{
			_reader = new SmartTextReader();
			_pattern = pattern;
		}

		public char[][] ReadText(string filePath)
		{
			if (Regex.IsMatch(filePath, _pattern))
			{
				Console.WriteLine("Access denied!");
				return new char[0][];
			}

			return _reader.ReadText(filePath);
		}
	}
}
