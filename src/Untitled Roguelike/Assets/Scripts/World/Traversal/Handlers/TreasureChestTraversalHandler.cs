using UnityEngine;

public class TreasureChestTraversalHandler : ITraversalHandler
{
    public string TagName { get { return WorldObjectTag.TreasureChest; } }

    public bool Hit(GameObject gameObject)
    {
        var treasureChest = gameObject.GetComponent<TreasureChest>();
        if (!treasureChest.Opened)
        {
            var openChest = new OpenChest(treasureChest);
            MessageQueue.Instance.Post(openChest);
        }

        return false; // Player cannot pass
    }
}