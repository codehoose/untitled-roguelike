public class DungeonRoom
{
    public int[] RoomShape { get; private set; }

    public ExitDirection Exits { get; private set; }

    public string LayerName { get; private set; }

    public DungeonRoom(string layerName, ExitDirection exits, int[] roomShape)
    {
        RoomShape = roomShape;
        Exits = exits;
        LayerName = layerName;
    }
}
