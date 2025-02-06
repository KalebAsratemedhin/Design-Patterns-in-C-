using System;

namespace DesignPatterns.src.Behavioural.Memento;

// The care taker
public class History
{
    private List<EditorState> editorStates = new List<EditorState>();
    private Editor editor;

    public History(Editor editor)
    {
        this.editor = editor; 
    }

    public void Save()
    {
        EditorState currentState = editor.CreateState();
        editorStates.Add(currentState);
    }

    public void Undo()
    {
        EditorState lastState = editorStates.Last();
        editorStates.Remove(lastState);
        editor.Restore(lastState);
    }

}
