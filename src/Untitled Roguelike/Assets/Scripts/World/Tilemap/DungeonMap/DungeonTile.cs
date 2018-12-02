using UnityEngine;

public class DungeonTile
{
    public Vector3Int Position { get; private set; }

    public int Id { get; private set; }

    public DungeonTile(int x, int y, int id)
    {
        Position = new Vector3Int(x, y, 0);
        Id = id;
    }
}
