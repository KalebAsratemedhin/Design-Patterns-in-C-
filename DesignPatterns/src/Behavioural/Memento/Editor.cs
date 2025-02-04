using System;

namespace DesignPatterns.src.Behavioural.Memento;

public class Editor
{
    public string Title {get; set;}
    public string Content { get; set; }

    public EditorState CreateState()
    {
        return new EditorState(this.Title, this.Content);
    }

    public void Restore(EditorState state)
    {
        this.Title = state.GetTitle();
        this.Content = state.GetContent();
    }

}
