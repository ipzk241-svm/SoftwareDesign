using Proxy.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.classes
{
	internal class SmartTextReader : ISmartTextReader
	{
		public char[][] ReadText(string filePath)
		{
			string[] lines = File.ReadAllLines(filePath);
			char[][] result = new char[lines.Length][];

			for (int i = 0; i < lines.Length; i++)
			{
				result[i] = lines[i].ToCharArray();
			}

			return result;
		}
	}
}
