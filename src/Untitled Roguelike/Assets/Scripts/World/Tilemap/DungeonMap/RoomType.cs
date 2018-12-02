public enum RoomType
{
    [RoomShape("sr-1", ExitDirection.South)]
    Bottom,

    [RoomShape("sr-2", ExitDirection.North | ExitDirection.South)]
    TopBottom,

    [RoomShape("sr-3", ExitDirection.North)]
    Top,

    [RoomShape("tlr", ExitDirection.North | ExitDirection.West | ExitDirection.East)]
    TopLeftRight,

    [RoomShape("fw", ExitDirection.All)]
    FourWay,

    [RoomShape("blr", ExitDirection.South | ExitDirection.West | ExitDirection.East)]
    BottomleftRight,

    [RoomShape("lr", ExitDirection.West | ExitDirection.East)]
    LeftRight,

    [RoomShape("r", ExitDirection.East)]
    Right,

    [RoomShape("l", ExitDirection.West)]
    Left
}
