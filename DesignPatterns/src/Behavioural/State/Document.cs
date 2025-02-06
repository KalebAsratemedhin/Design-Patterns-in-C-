using System;

namespace DesignPatterns.src.Behavioural.State;

public class Document
{
    public State State;
    public UserRoles UserRole;

    public Document(UserRoles CurrentRole)
    {
        UserRole = CurrentRole;
        State = new DraftState(this);
    }

    public void Publish()
    {
        State.Publish();
    }
}
