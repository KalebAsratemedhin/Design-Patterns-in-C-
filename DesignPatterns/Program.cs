
using DesignPatterns.src.Behavioural.Iterator;
using DesignPatterns.src.Behavioural.Memento;
using DesignPatterns.src.Behavioural.State;
using DesignPatterns.src.Behavioural.Strategy;

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

// Document document = new Document(UserRoles.Editor);
// Console.WriteLine("State" + document.State);
// document.Publish();
// Console.WriteLine("State" + document.State);
// document.Publish();
// Console.WriteLine("State" + document.State);
// document.UserRole = UserRoles.Admin;
// document.Publish();
// Console.WriteLine("State" + document.State);

// MkvCompressor mkvCompressor = new MkvCompressor();
// MovCompressor movCompressor = new MovCompressor();
// BlurOverlay blurOverlay = new BlurOverlay();

// VideoStorage storage = new VideoStorage(mkvCompressor, blurOverlay);
// VideoStorage storage2 = new VideoStorage(movCompressor, blurOverlay);

// storage.Store();
// storage2.Store();


ShoppingList shoppingList = new ShoppingList();
shoppingList.Push("Beer");
shoppingList.Push("Soda");
shoppingList.Push("glasses");
shoppingList.Push("eggs");


IIterator<string> iterator = shoppingList.CreateIterator();

while (iterator.HasNext())
{
    System.Console.WriteLine(iterator.Current());
    iterator.Next();
}





