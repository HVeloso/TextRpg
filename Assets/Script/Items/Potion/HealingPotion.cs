public class HealingPotion : IItem, IPotion
{
	// Parameters
	private int _numberOfCopies = 1;
	private const float _healingValue = 78.0f;

	// Properties
	public int Quantity => _numberOfCopies;
	public ItemType Type => ItemType.Potion;

	// Item Functions
	public void AddItem() => _numberOfCopies++;
	public void RemoveItem() => _numberOfCopies--;

	// Potion Functions
	public void UsePostion(IStatusSheet statusSheet)
	{
		statusSheet.Health += _healingValue;
	}
}
