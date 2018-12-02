using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RoomTypeMap
{
    private Dictionary<string, RoomWithDirection> _rooms = new Dictionary<string, RoomWithDirection>();

    public RoomTypeMap()
    {
        var values = Enum.GetValues(typeof(RoomType));
        foreach (RoomType roomType in values)
        {
            var field = typeof(RoomType).GetField(roomType.ToString());
            RoomShapeAttribute roomShape = field.GetCustomAttributes(typeof(RoomShapeAttribute), false).FirstOrDefault() as RoomShapeAttribute;
            var roomWithDir = new RoomWithDirection();
            roomWithDir.exits = roomShape.Exits;
            roomWithDir.roomType = roomType;
            _rooms[roomShape.LayerName] = roomWithDir;
        }
    }

    public RoomWithDirection GetFrom(string layerName)
    {
        return _rooms[layerName];
    }
}

public struct RoomWithDirection
{
    public RoomType roomType;
    public ExitDirection exits;
}

