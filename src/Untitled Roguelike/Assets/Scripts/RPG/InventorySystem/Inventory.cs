using System.Collections.Generic;

public class Inventory
{
    private int _maxSlots;

    private List<IItem> _items = new List<IItem>();

    public IList<IItem> Items { get { return _items; } }

    public Inventory(int maxSlots = int.MaxValue)
    {
        _maxSlots = maxSlots;
    }

    public bool Pickup(IItem newItem)
    {
        if (_items.Count >= _maxSlots)
            return false;

        _items.Add(newItem);
        return true;
    }

    public void Drop(IItem item)
    {
        _items.Remove(item);
    }

    public void Drop(int index)
    {
        if (index < 0 || index >= _items.Count)
            return;

        _items.RemoveAt(index);
    }
}
