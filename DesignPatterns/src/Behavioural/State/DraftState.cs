using System;

namespace DesignPatterns.src.Behavioural.State;

public class DraftState: State
{
    private Document _document;

    public DraftState(Document document)
    {
        _document = document;

    }

    public void Publish()
    {
        _document.State = new ModeratorState(_document);
    }


}
