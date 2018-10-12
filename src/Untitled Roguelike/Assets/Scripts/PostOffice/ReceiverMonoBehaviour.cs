using UnityEngine;

public abstract class ReceiverMonoBehaviour<TMessage> : MonoBehaviour, IReceiver where TMessage : IMessage
{
    public abstract void Handle(TMessage message);

    protected abstract void OnAwake();

    void IReceiver.Handle(IMessage message)
    {
        Handle((TMessage)message);
    }

    private void Awake()
    {
        MessageQueue.Instance.Register<TMessage>(this);
        OnAwake();
    }
}
