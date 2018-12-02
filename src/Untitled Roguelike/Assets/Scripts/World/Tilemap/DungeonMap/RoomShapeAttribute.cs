using System;

public class RoomShapeAttribute : Attribute
{
    public string LayerName { get; private set; }

    public ExitDirection Exits { get; private set; }

    public RoomShapeAttribute(string layerName, ExitDirection exits)
    {
        LayerName = layerName;
        Exits = exits;
    }
}
