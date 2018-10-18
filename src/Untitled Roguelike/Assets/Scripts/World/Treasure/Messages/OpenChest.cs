public class OpenChest : BaseMessage
{
    public TreasureChest TreasureChest { get; private set; }

    public OpenChest(TreasureChest treasureChest) 
        : base("OpenChest")
    {
        TreasureChest = treasureChest;
    }
}
