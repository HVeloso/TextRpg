public interface IItem
{
	public int Quantity { get; set; }
	public ItemType Type { get; set; }

	public void AddItem();
	public void RemoveItem();
	public void UseItem(EntityStatusSheet entityStatus);
}
