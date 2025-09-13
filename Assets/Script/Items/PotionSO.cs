using UnityEngine;

[CreateAssetMenu(fileName = "New Potion", menuName = "Item/PotionSO")]
public class PotionSO : ScriptableObject
{
	[Header("Potion Parameters")]
	[SerializeField] private string _potionName;
	[SerializeField][TextArea] private string _potionDescription;
	[SerializeField][Min(1)] private int _maxQuantity;
	[SerializeField] private int _potionEffect; // Alterar pelo script de controle de efeito da poção

	public string PotionName => _potionName;
	public string PotionDescription => _potionDescription;
	public int MaxQuantity => _maxQuantity;
}
