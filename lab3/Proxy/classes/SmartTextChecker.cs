using Proxy.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.classes
{
	internal class SmartTextChecker : ISmartTextReader
	{
		private SmartTextReader _reader;

		public SmartTextChecker()
		{
			_reader = new SmartTextReader();
		}

		public char[][] ReadText(string filePath)
		{
			Console.WriteLine($"Attempting to open file: {filePath}");

			char[][] result = _reader.ReadText(filePath);

			Console.WriteLine($"File successfully read");
			Console.WriteLine($"Total lines: {result.Length}");

			int totalChars = 0;
			foreach (var line in result)
			{
				totalChars += line.Length;
			}
			Console.WriteLine($"Total characters: {totalChars}");
			Console.WriteLine($"File processing completed");

			return result;
		}
	}
}
