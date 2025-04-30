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
		private IImageLoaderFactory _loaderFactory;
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
			_loaderFactory = new ImageLoaderFactory();
			Href = href;
		}
		public void SetLoader(IImageLoader strategy)
		{
			_loader = strategy;
		}
		public void SetLoader(string href)
		{
			_loader = _loaderFactory.CreateLoader(href);
		}
		public override string OuterHTML =>  $"<img src=\"{Href}\" alt=\"{_loader.Load(Href)}\"/>";

		public override string InnerHTML => "";

		public string Render()
		{
			return OuterHTML;
		}

		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
