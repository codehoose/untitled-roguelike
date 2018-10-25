using UnityEngine;

public static class Vector3Extensions
{
    public static Vector3 Add(this Vector3 left, Vector2 right)
    {
        return new Vector3(left.x + right.x, left.y + right.y, 0f);
    }
}

