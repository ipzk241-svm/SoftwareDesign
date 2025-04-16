using Memento;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
var editor = new TextEditor();

editor.Type("Hello, ");
editor.Show();

editor.Type("world!");
editor.Show();

Console.WriteLine("\nUndo last change...");
editor.Undo();
editor.Show();

Console.WriteLine("\nClear document...");
editor.Clear();
editor.Show();

Console.WriteLine("\nUndo clear...");
editor.Undo();
editor.Show();
