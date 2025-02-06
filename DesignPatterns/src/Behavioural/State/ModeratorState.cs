using System;

namespace DesignPatterns.src.Behavioural.State;

public class ModeratorState: State
{

    private Document _document;

    public ModeratorState(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        if(_document.UserRole == UserRoles.Admin)
        {
            _document.State = new PublishedState(_document);
        }
    }
}
