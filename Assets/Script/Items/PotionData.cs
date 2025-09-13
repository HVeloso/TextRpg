using System;
using UnityEngine;

[Serializable]
public class PotionData : IItem, IPotion
{
	[SerializeField] private PotionSO _potionParameters;
	private int _currentQuantity = 1;

	public ItemType Type => ItemType.Potion;
	public int Quantity => _currentQuantity;
	public string Name => _potionParameters.PotionName;
	public string Description => _potionParameters.PotionDescription;

	// Returns TRUE if the quantity was successful increased
	public bool AddItem()
	{
		if (_currentQuantity >= _potionParameters.MaxQuantity) return false;

		_currentQuantity++;
		return true;
	}

	// Returns TRUE if there are still potions
	public bool RemoveItem()
	{
		_currentQuantity--;
		return _currentQuantity > 0;
	}

	public void UsePotion()
	{
		throw new NotImplementedException();
	}
}
