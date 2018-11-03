public class PlayerVitals : ReceiverMonoBehaviour<VitalsMessage>
{
    public int armour = 0;
    public int hitPoints = 10;
    public int meleeAttack = 0;
    public int rangeAttack = 0;

    public override void Handle(VitalsMessage message)
    {
        message.Apply(this);
    }

    protected override void OnAwake()
    {
        
    }
}
