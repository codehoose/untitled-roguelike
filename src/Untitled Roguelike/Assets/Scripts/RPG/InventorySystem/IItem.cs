/// <summary>
/// An inventory item.
/// </summary>
public interface IItem
{
    /// <summary>
    /// The name of the item.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Equip the item. (this can also mean consume ;)
    /// </summary>
    void Equip();

    /// <summary>
    /// Unequip the item.
    /// </summary>
    void UnEquip();
}
