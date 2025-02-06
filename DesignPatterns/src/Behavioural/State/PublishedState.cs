using System;

namespace DesignPatterns.src.Behavioural.State;

public class PublishedState: State
{
    private Document _document;

    public PublishedState(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        
    }
}
