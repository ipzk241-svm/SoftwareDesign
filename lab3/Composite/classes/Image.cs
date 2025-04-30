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
			get => href;
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

		public override string OuterHTML => $"<img src=\"{Href}\" alt=\"{_loader.Load(Href)}\"/>";

		public override string InnerHTML => "";

		protected override string RenderContent(int indentLevel)
		{
			OnStylesApplied();
			OnClassListApplied();
			OnInserted();

			string indent = new string(' ', indentLevel * 2);
			string result = indent + OuterHTML;

			OnRemoved(); 
			return result;
		}

		protected override void OnCreated() => Console.WriteLine("Image created");
		protected override void OnInserted() => Console.WriteLine("Image inserted");
		protected override void OnRemoved() => Console.WriteLine("Image removed");
		protected override void OnTextRendered() => Console.WriteLine("Image text rendered");
		protected virtual void OnStylesApplied() => Console.WriteLine("Image styles applied");
		protected virtual void OnClassListApplied() => Console.WriteLine("Image class list applied");

		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
