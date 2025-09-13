using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Item/WeaponSO")]
public class WeaponSO : ScriptableObject
{
	[Header("Weapon Parameters")]
	[SerializeField] private string _weaponName;
	[SerializeField][TextArea] private string _weaponDescription;
	[SerializeField][Min(0)] private float _highestDamageModifier;
	[SerializeField][Min(0)] private float _lowestDamageModifier;
	[SerializeField] private int _weaponEffect; // Alterar pelo script de controle de efeito da arma

	public string WeaponName => _weaponName;
	public string WeaponDescription => _weaponDescription;
	public float HighestDamageModifier => _highestDamageModifier;
	public float LowestDamageModifier => _lowestDamageModifier;
}
