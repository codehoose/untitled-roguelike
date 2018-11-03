using UnityEngine;

class MobTraversalHandler : ITraversalHandler
{
    public string TagName { get { return WorldObjectTag.Mob; } }

    public bool Hit(GameObject gameObject)
    {
        var mob = gameObject.GetComponent<Mob>();
        var message = new MeleeAttackMobMessage(mob);
        MessageQueue.Instance.Post(message);

        return false; // Player cannot pass
    }
}
