using System;
using System.Collections.Generic;

public class PlayerInventory : IInventory, IInventoryEquipped, IWallet
{
	// Constants
	private const int c_numberOfWeapons = 2;
	private const int c_numberOfPotions = 3;

	// Inventory
	private readonly Dictionary<ItemType, List<IItem>> _playerItems;
	private readonly IWeapon[] _equippedWeapons;
	private readonly IPotion[] _equippedConsumables;
	
	// Wallet
	private float _money;

	// Initialization
	public PlayerInventory()
	{
		_playerItems = new();
		_equippedConsumables = new IPotion[c_numberOfPotions];
		_equippedWeapons = new IWeapon[c_numberOfWeapons];
		
		InitializeItemsList();
	}

	private void InitializeItemsList()
	{
		foreach (ItemType type in Enum.GetValues(typeof(ItemType)))
		{
			_playerItems.Add(type, new List<IItem>());
		}
	}

	// Inventory Functions
	public List<IItem> GetItems(ItemType type) => _playerItems[type];

	public void AddItem(IItem item)
	{
		if (_playerItems[item.Type].Contains(item))
		{
			int idx = _playerItems[item.Type].IndexOf(item);
			_playerItems[item.Type][idx].AddItem();
		}
		else
		{
			_playerItems[item.Type].Add(item);
		}
	}

	public void SubtractItem(IItem item)
	{
		if (!_playerItems[item.Type].Contains(item)) return;

		int idx = _playerItems[item.Type].IndexOf(item);

		_playerItems[item.Type][idx].RemoveItem();

		if (_playerItems[item.Type][idx].Quantity <= 0)
			_playerItems[item.Type].Remove(item);
	}

	public void RemoveItem(IItem item)
	{
		if (!_playerItems[item.Type].Contains(item)) return;

		_playerItems[item.Type].Remove(item);
	}

	// Inventory Equipped Functions
	public void RegisterWeapon(int weaponIdx, IWeapon item) => _equippedWeapons[weaponIdx] = item;
	public void UnregisterWeapon(int weaponIdx) => _equippedWeapons[weaponIdx] = null;
	public IWeapon GetWeapon(int weaponIdx) => _equippedWeapons[weaponIdx];

	public void RegisterConsumable(int consumableIdx, IPotion item) => _equippedConsumables[consumableIdx] = item;
	public void UnregisterConsumable(int consumableIdx) => _equippedConsumables[consumableIdx] = null;
	public IPotion GetConsumable(int consumableIdx) => _equippedConsumables[consumableIdx];

	// Wallet Functions
	public float GetMoneyQuantity() => _money;

	public void IncreaseMoney(float moneyToAdd)
	{
		if (moneyToAdd < 0) return;
		_money += moneyToAdd;
	}

	public bool TryBuy(float moneyToDecrease)
	{
		if (moneyToDecrease < 0f || moneyToDecrease > _money) return false;

		_money -= moneyToDecrease;
		return true;
	}
}
