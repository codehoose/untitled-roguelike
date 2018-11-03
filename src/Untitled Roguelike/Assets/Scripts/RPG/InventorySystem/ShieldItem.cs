using System;

public class ShieldItem : IItem
{
    private Action _equip;

    private Action _unequip;

    public string Name { get; private set; }

    public void Equip()
    {
        if (_equip != null)
            _equip();
    }

    public void UnEquip()
    {
        if (_unequip != null)
            _unequip();
    }

    public ShieldItem(string name, Action equip, Action unequip)
    {
        Name = name;
        _equip = equip;
        _unequip = unequip;
    }
}
