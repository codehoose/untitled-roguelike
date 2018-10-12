using UnityEngine;

public class MovePlayer : BaseMessage
{
    public Vector2 Direction { get; private set; }

    public MovePlayer(Vector2 direction)
        : base("MovePlayer")
    {
        Direction = direction;
    }
}
