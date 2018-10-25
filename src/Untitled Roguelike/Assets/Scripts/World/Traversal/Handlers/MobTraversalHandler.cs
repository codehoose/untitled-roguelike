using UnityEngine;

class MobTraversalHandler : ITraversalHandler
{
    public string TagName { get { return WorldObjectTag.Mob; } }

    public bool Hit(GameObject gameObject)
    {
        // TODO: How do we handle superior weapons? Like if the player is carrying
        // a +4 broadsword?

        var mob = gameObject.GetComponent<Mob>();
        mob.health--;
        if (mob.health == 0)
        {
            GameObject.Destroy(gameObject);
        }
        
        return false; // Player cannot pass
    }
}
