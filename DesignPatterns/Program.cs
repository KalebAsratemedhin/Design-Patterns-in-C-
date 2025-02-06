
using DesignPatterns.src.Behavioural.Memento;
using DesignPatterns.src.Behavioural.State;

// Editor editor = new Editor();
// History history = new History(editor);

// editor.Title = "This is great";
// editor.Content = "Hello";

// history.Save();

// Console.WriteLine("Title: " + editor.Title + " Content: " + editor.Content);
// editor.Title = "Bullshit";
// Console.WriteLine("Title: " + editor.Title + " Content: " + editor.Content);

// history.Undo();


// Console.WriteLine("Title: " + editor.Title + " Content: " + editor.Content);

Document document = new Document(UserRoles.Editor);
Console.WriteLine("State" + document.State);
document.Publish();
Console.WriteLine("State" + document.State);
document.Publish();
Console.WriteLine("State" + document.State);
document.UserRole = UserRoles.Admin;
document.Publish();
Console.WriteLine("State" + document.State);

