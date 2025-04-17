using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	internal class FileImageLoader : IImageLoader
	{
		public string Load(string href)
		{
			return $"[Image loaded from file: {Path.GetFileName(href)}]";
		}
	}
}
