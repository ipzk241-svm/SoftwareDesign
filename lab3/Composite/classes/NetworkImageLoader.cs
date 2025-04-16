namespace Composite.classes
{
	internal class NetworkImageLoader : IImageLoader
	{
		public string Load(string href)
		{
			return $"[Image loaded from URL: {href}]";
		}
	}
}