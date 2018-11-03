public class MeleeAttackMobMessage : BaseMessage
{
    public Mob Mob { get; private set; }

    public MeleeAttackMobMessage(Mob mob) 
        : base("MeleeAttackMob")
    {
        Mob = mob;
    }
}