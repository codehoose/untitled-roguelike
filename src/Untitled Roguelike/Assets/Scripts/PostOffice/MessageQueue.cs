using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageQueue : MonoBehaviour
{
    #region Singleton Pattern

    private static MessageQueue _instance;

    public static MessageQueue Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<MessageQueue>();
                if (_instance == null)
                {
                    var go = new GameObject("__MessageQueue");
                    _instance = go.AddComponent<MessageQueue>();
                }
            }

            return _instance;
        }
    }

    #endregion

    private Dictionary<Type, List<IReceiver>> _receivers;

    private void Awake()
    {
        _receivers = new Dictionary<Type, List<IReceiver>>();
    }

    public void Register<TMessage>(IReceiver receiver) where TMessage : IMessage
    {
        if (!_receivers.ContainsKey(typeof(TMessage)))
        {
            _receivers[typeof(TMessage)] = new List<IReceiver>();
        }

        var list = _receivers[typeof(TMessage)];
        if (!list.Contains(receiver))
            list.Add(receiver);
    }

    public void Register<TMessage>(Action<TMessage> action) where TMessage : IMessage
    {
        var methodReceiver = new MethodReceiver<TMessage>(action);
        Register<TMessage>(methodReceiver);
    }

    public void Post(BaseMessage message)
    {
        if (!_receivers.ContainsKey(message.GetType()))
        {
            return;
        }

        var list = _receivers[message.GetType()];
        foreach (var receiver in list)
        {
            receiver.Handle(message);
        }
    }
}
