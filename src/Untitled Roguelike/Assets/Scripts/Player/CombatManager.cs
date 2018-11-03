using UnityEngine;

[RequireComponent(typeof(PlayerVitals))]
public class CombatManager : ReceiverMonoBehaviour<MeleeAttackMobMessage>
{
    private PlayerVitals _vitals;

    public override void Handle(MeleeAttackMobMessage message)
    {
        var mob = message.Mob;
        mob.health -= _vitals.meleeAttack;

        if (mob.health <= 0)
        {
            Destroy(mob.gameObject);
        }
    }

    protected override void OnAwake()
    {
        _vitals = GetComponent<PlayerVitals>();
    }
}
