using System.Collections.Generic;
using UnityEngine;

public class Dungeon
{
    private Dictionary<RoomType, DungeonRoom> _rooms = new Dictionary<RoomType, DungeonRoom>();
    
    public Dungeon(string resourceLocation)
    {
        var dungeonJson = Resources.Load<TextAsset>(resourceLocation).text;
        var tilemapModel = JsonUtility.FromJson<TilemapModel>(dungeonJson);

        var roomTypeMap = new RoomTypeMap();

        foreach (var dungeonModel in tilemapModel.layers)
        {
            var data = roomTypeMap.GetFrom(dungeonModel.name);
            _rooms[data.roomType] = new DungeonRoom(dungeonModel.name, data.exits, dungeonModel.data);
        }
    }

    public IEnumerable<DungeonTile> Generate()
    {
        var blocks = GetRoom(RoomType.LeftRight).RoomShape;
        IList<DungeonTile> tiles = new List<DungeonTile>();

        for (int y = 0; y < 12; y++)
        {
            for (int x = 0; x < 16; x++)
            {
                var blockId = blocks[y * 16 + x] - 1;
                if (blockId < 0)
                    continue;

                var actualY = 6 - y;
                var actualX = -8 + x;

                tiles.Add(new DungeonTile(actualX, actualY, blockId));
            }
        }

        return tiles;
    }

    public DungeonRoom GetRoom(RoomType roomType)
    {
        return _rooms[roomType];
    }
}
