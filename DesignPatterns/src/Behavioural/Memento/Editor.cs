using System;

namespace DesignPatterns.src.Behavioural.Memento;

public class Editor
{
    public string Title {get; set;}
    public string Content { get; set; }

    public EditorState CreateState()
    {
        // take a snapshot of the editor at this point in time
        return new EditorState(this.Title, this.Content);
    }

    public void Restore(EditorState state)
    {
        // given a particular screenshot, restore the editor to that snapshot
        this.Title = state.GetTitle();
        this.Content = state.GetContent();
    }

}
