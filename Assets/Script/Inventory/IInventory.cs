using System.Collections.Generic;

public interface IInventory
{
	public List<IItem> GetItems(ItemType type);
	public void AddItem(IItem item);
	public void RemoveItem(IItem item);
}
