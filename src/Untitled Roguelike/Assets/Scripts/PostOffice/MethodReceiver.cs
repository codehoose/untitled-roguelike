using System;

public class MethodReceiver<TMessage> : IReceiver where TMessage : IMessage
{
    private Action<TMessage> _action;

    public MethodReceiver(Action<TMessage> action)
    {
        _action = action;
    }
    
    public void Handle(TMessage message)
    {
        _action(message);    
    }

    void IReceiver.Handle(IMessage message)
    {
        Handle((TMessage)message);
    }
}
