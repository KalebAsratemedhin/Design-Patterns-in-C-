
using DesignPatterns.src.Behavioural.Memento;

Editor editor = new Editor();
History history = new History(editor);

editor.Title = "This is great";
editor.Content = "Hello";

history.Save();

Console.WriteLine("Title: " + editor.Title + " Content: " + editor.Content);
editor.Title = "Bullshit";
Console.WriteLine("Title: " + editor.Title + " Content: " + editor.Content);

history.Undo();


Console.WriteLine("Title: " + editor.Title + " Content: " + editor.Content);



