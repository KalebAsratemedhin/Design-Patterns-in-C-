using System;

namespace DesignPatterns.src.Behavioural.Memento;

// A representation of the snapshot of the editor
public class EditorState
{
    private readonly string _title;
    private readonly string _content;

    private readonly DateTime _createdAt;

    public EditorState(string title, string content)
    {
        this._title = title;
        this._content = content;
        this._createdAt = DateTime.Now;
    }

    public string GetTitle()
    {
        return this._title;
    }
    public string GetContent()
    {
        return this._content;
    }
    public DateTime GetCreatedAt()
    {
        return this._createdAt;
    }
    

}
