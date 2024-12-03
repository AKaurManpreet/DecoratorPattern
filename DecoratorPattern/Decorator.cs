using System;

public abstract class Decorator<T> : IComponent<T>
{
    protected IComponent<T> component;

    protected Decorator(IComponent<T> component)
    {
        this.component = component;
    }

    public virtual T GetText()
    {
        return component.GetText();
    }
}
