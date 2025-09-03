using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Item", menuName = "Item/Weapon")]
public class WeaponItemSO : ScriptableObject, IItem, IWeapon
{
	[Header("Weapon Parameters")]
	[SerializeField] private string _weaponName;
	[Space]
	[SerializeField] private float _lowestDamageMultiplier;
	[SerializeField] private float _highestDamageMultiplier;
	
	// Item Variables
	private int _numberOfCopies = 1;

	// Weapon Variables
	private float _lowestDamage = 0f;
	private float _highestDamage = 1f;

	// Item Properties
	public string Name => _weaponName;
	public int Quantity => _numberOfCopies;
	public ItemType Type => ItemType.Weapon;

	// Weapon Properties
	public float LowestDamage => _lowestDamage;
	public float HighestDamage => _highestDamage;

	// Item Functions
	public void AddItem() => _numberOfCopies++;
	public void RemoveItem() => _numberOfCopies--;

	// Weapon Functions
	public void UpdateWeaponValues(IStatusSheet statusSheet)
	{
		float currentStrength = statusSheet.GetStat(StatType.Strength).GetValue(StatValueType.Current);

		_lowestDamage = currentStrength * _lowestDamageMultiplier;
		_highestDamage = currentStrength * _highestDamageMultiplier;
	}	
}
