public interface IItem
{
	public string Name { get; }
	public int Quantity { get; }
	public ItemType Type { get; }

	public void AddItem();
	public void RemoveItem();
}
