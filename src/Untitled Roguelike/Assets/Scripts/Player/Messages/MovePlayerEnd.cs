using UnityEngine;

public class MovePlayerEnd : BaseMessage
{
    public Vector3 Start { get; private set; }

    public Vector3 End { get; private set; }

    public MovePlayerEnd(Vector3 start, Vector3 end)
        : base("MovePlayerEnd")
    {
        Start = start;
        End = end;
    }
}
