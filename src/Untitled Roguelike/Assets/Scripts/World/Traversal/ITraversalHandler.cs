using UnityEngine;

public interface ITraversalHandler
{
    string TagName { get; }

    bool Hit(GameObject gameObject);
}
