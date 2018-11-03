using UnityEngine;

public class Backpack : MonoBehaviour
{
    private Inventory _inventory;
    private EquippedItems _equipped;

    void Awake()
    {
        _inventory = new Inventory();
        _equipped = new EquippedItems();
    }

    // TODO: This really should work on awake, but for the sake of a shorter
    // video 4 we called this method from start()
    void Start()
    {
        AddDefaultItems();
    }

    public void Pickup(IItem item)
    {
        _inventory.Pickup(item);
    }

    public void DropItem(IItem item)
    {
        _inventory.Drop(item);
    }

    public void EquipMainHand(WeaponItem weapon)
    {
        if (_equipped.MainHand != null)
            _equipped.MainHand.UnEquip();

        weapon.Equip(w => _equipped.MainHand = w);
    }

    public void EquipOffHand(WeaponItem weapon)
    {
        if (_equipped.OffHand != null)
            _equipped.OffHand.UnEquip();

        weapon.Equip(w => _equipped.OffHand = w);
    }

    public void EquipShield(ShieldItem shield)
    {
        if (_equipped.Shield != null)
            _equipped.Shield.UnEquip();

        shield.Equip();
    }

    private void AddDefaultItems()
    {
        var sword = new WeaponItem("Wooden sword", 
                                   WeaponType.Melee, 
                                   () => VitalsMessage.CreateMelee(1).Post(), 
                                   () => VitalsMessage.CreateMelee(-1).Post());

        var shield = new ShieldItem("Wooden shield",
                                    () => VitalsMessage.CreateArmour(1).Post(),
                                    () => VitalsMessage.CreateArmour(-1).Post());

        Pickup(sword);
        Pickup(shield);

        EquipMainHand(sword);
        EquipShield(shield);
    }
}
