using System;
using System.Collections.Generic;
using UnityEngine;

public class TraversalManager : SingletonBehaviour<TraversalManager>
{
    private Dictionary<string, ITraversalHandler> _handlers = new Dictionary<string, ITraversalHandler>();

    // TODO: This is quite costly and will hurt performance on first hit
    // Let's re-write this when we do the game manager class!
    private void Awake()
    {
        var types = GetType().Assembly.GetTypes();
        foreach (var type in types)
        {
            if (type.GetInterface(typeof(ITraversalHandler).Name) != null)
            {
                var instance = Activator.CreateInstance(type) as ITraversalHandler;
                _handlers[instance.TagName] = instance;
            }
        }
    }

    public bool CanMovePlayer(Vector3 position, Vector2 direction)
    {
        var hit = Physics2D.Raycast(position, direction, 1f);
        if (hit.collider == null)
            return true;

        ITraversalHandler traversalHandler = null;
        if (_handlers.TryGetValue(hit.collider.tag, out traversalHandler))
        {
            return traversalHandler.Hit(hit.collider.gameObject);
        }

        return true;
    }
}
