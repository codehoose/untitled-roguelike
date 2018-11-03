using System;

public class WeaponItem : IItem
{
    Action _equip;

    Action _unequip;

    public string Name { get; private set; }

    public WeaponType WeaponType { get; private set; }

    public void Equip(Action<WeaponItem> placeWeapon)
    {
        if (_equip != null)
        {
            _equip();
            if (placeWeapon != null)
                placeWeapon(this);
        }
    }

    public void Equip()
    {
        Equip(null);
    }

    public void UnEquip()
    {
        if (_unequip != null)
            _unequip();
    }

    public WeaponItem(string name, WeaponType weaponType, Action equipAction, Action unequipAction)
    {
        Name = name;
        WeaponType = weaponType;
        _equip = equipAction;
        _unequip = unequipAction;
    }
}
