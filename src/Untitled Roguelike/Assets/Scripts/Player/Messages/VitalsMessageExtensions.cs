public static class VitalsMessageExtensions
{
    public static void Post(this VitalsMessage message)
    {
        MessageQueue.Instance.Post(message);
    }

    public static void Apply(this VitalsMessage message, PlayerVitals vitals)
    {
        vitals.armour += message.ArmourDelta;
        vitals.hitPoints += message.HitPointDelta;
        vitals.meleeAttack += message.MeleeAttackDelta;
        vitals.rangeAttack += message.RangeAttackDelta;
    }
}
