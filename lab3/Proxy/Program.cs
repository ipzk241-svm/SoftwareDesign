using Proxy.classes;
using Proxy.interfaces;

string testFilePath = "test.txt";
File.WriteAllText(testFilePath, "Hello\nWorld\nTest");

string restrictedFilePath = "secret.txt";
File.WriteAllText(restrictedFilePath, "Top Secret Data");

Console.WriteLine("Basic SmartTextReader:");
ISmartTextReader basicReader = new SmartTextReader();
char[][] text = basicReader.ReadText(testFilePath);
PrintTextArray(text);
Console.WriteLine();

Console.WriteLine("SmartTextChecker:");
ISmartTextReader checker = new SmartTextChecker();
text = checker.ReadText(testFilePath);
Console.WriteLine();

Console.WriteLine("SmartTextReaderLocker:");
ISmartTextReader locker = new SmartTextReaderLocker("secret");

Console.WriteLine("Trying allowed file:");
text = locker.ReadText(testFilePath);
PrintTextArray(text);

Console.WriteLine("\nTrying restricted file:");
text = locker.ReadText(restrictedFilePath);

static void PrintTextArray(char[][] text)
{
	foreach (var line in text)
	{
		Console.WriteLine(new string(line));
	}
}