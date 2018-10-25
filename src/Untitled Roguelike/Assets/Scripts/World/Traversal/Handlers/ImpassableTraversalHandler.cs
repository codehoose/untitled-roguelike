using UnityEngine;

public class ImpassableTraversalHandler : ITraversalHandler
{
    public string TagName { get { return WorldObjectTag.Impassable; } }

    public bool Hit(GameObject gameObject)
    {
        return false; // Player cannot pass
    }
}
