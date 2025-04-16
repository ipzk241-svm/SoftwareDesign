using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public class Image : LightNode
	{
		private string href;
		private IImageLoader _loader;

		public string Href
		{
			get { return href; }
			set
			{
				SetLoader(value);
				href = value;
			}
		}

		public Image(string href)
		{
			Href = href;

			SetLoader(href);
		}
		public void SetLoader(IImageLoader strategy)
		{
			_loader = strategy;
		}
		public void SetLoader(string href)
		{
			if (href.StartsWith("http://") || href.StartsWith("https://"))
				_loader = new NetworkImageLoader();
			else
				_loader = new FileImageLoader();
		}
		public override string OuterHTML => $"<img src=\"{Href}\" alt=\"{_loader.Load(Href)}\"/>";

		public override string InnerHTML => "";
	}
}
