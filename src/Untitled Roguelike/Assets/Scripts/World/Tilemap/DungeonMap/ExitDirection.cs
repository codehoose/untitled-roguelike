using System;

[Flags]
public enum ExitDirection
{
    North,
    South,
    East,
    West,
    All = North | South | East | West
}
