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