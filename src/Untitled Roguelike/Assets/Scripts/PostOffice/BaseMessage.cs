public abstract class BaseMessage : IMessage
{
    public string Name { get; private set; }

    public BaseMessage(string name)
    {
        Name = name;
    }
}
