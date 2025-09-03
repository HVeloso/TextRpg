using UnityEngine;

[CreateAssetMenu(fileName = "Potion Item", menuName = "Item/Potion")]
public class PotionItemSO : ScriptableObject, IItem, IPotion
{
	[Header("Weapon Parameters")]
	[SerializeField] private string _potionName;
	
	// Item Variables
	private int _numberOfCopies = 1;

	// Item Properties
	public string Name => _potionName;
	public int Quantity => _numberOfCopies;
	public ItemType Type => ItemType.Potion;

	// Item Functions
	public void AddItem() => _numberOfCopies++;
	public void RemoveItem() => _numberOfCopies--;

	// Potion Functions
	public void UsePostion(IStatusSheet statusSheet) { }
}
