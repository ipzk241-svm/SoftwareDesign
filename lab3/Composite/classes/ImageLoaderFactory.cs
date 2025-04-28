using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public interface IImageLoaderFactory
	{
		IImageLoader CreateLoader(string href);
	}

	public class ImageLoaderFactory : IImageLoaderFactory
	{
		public IImageLoader CreateLoader(string href)
		{
			if (href.StartsWith("http://") || href.StartsWith("https://"))
				return new NetworkImageLoader();
			else
				return new FileImageLoader();
		}
	}
}
