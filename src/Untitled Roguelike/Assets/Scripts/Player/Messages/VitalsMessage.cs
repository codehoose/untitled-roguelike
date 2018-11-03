public class VitalsMessage : BaseMessage
{
    public int ArmourDelta { get; private set; }
    public int HitPointDelta { get; private set; }
    public int MeleeAttackDelta { get; private set; }
    public int RangeAttackDelta { get; private set; }

    public static VitalsMessage CreateMelee(int meleeDelta)
    {
        return new VitalsMessage(meleeDelta, 0, 0, 0);
    }

    public static VitalsMessage CreateRange(int rangeDelta)
    {
        return new VitalsMessage(0, rangeDelta, 0, 0);
    }

    public static VitalsMessage CreateHitPoint(int hitPointDelta)
    {
        return new VitalsMessage(0, 0, hitPointDelta, 0);
    }

    public static VitalsMessage CreateArmour(int armourDelta)
    {
        return new VitalsMessage(0, 0, 0, armourDelta);
    }

    public VitalsMessage(int meleeDelta, int rangeDelta, int hitPointDelta, int armourDelta)
        : base("Vitals Message")
    {
        ArmourDelta = armourDelta;
        HitPointDelta = hitPointDelta;
        MeleeAttackDelta = meleeDelta;
        RangeAttackDelta = rangeDelta;
    }
}
