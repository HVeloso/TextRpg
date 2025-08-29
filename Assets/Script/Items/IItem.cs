public interface IItem
{
	public int Quantity { get; }
	public ItemType Type { get; }

	public void AddItem();
	public void RemoveItem();
}
