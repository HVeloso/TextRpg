using System;
using UnityEngine;

[Serializable]
public class WeaponData : IItem, IWeapon
{
	[SerializeField] private WeaponSO _weaponParameters;
	private float _highestDamage;
	private float _lowestDamage;

	public ItemType Type => ItemType.Weapon;
	public string Name => _weaponParameters.WeaponName;
	public string Description => _weaponParameters.WeaponDescription;
	public float HighestDamage => _highestDamage;
	public float LowestDamage => _lowestDamage;

	public void UpdateDamage()
	{
		_highestDamage = _weaponParameters.HighestDamageModifier;
		_lowestDamage = _weaponParameters.LowestDamageModifier;
	}
}
