public class WoodSword : IItem, IWeapon
{
	// Constants
	private const float c_lowestDamageMultiplier = 0.85f;
	private const float c_highestDamageMultiplier = 1.1f;

	// Parameters
	private int _numberOfCopies = 1;
	private float _lowestDamage = 0f;
	private float _highestDamage = 1f;

	// Properties
	public int Quantity => _numberOfCopies;
	public ItemType Type => ItemType.Weapon;
	public float LowestDamage => _lowestDamage;
	public float HighestDamage => _highestDamage;

	// Item Functions
	public void AddItem() => _numberOfCopies++;
	public void RemoveItem() => _numberOfCopies--;

	// Weapon Functions
	public void UpdateWeaponValues(IStatusSheet statusSheet)
	{
		float currentStrength = statusSheet.GetStat(StatType.Strength).GetValue(StatValueType.Current);

		_lowestDamage = currentStrength * c_lowestDamageMultiplier;
		_highestDamage = currentStrength * c_highestDamageMultiplier;
	}
}
