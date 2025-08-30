using UnityEngine;

[CreateAssetMenu(fileName = "EntityBaseStatus", menuName = "Entity/Status")]
public class EntityBaseStatus : ScriptableObject
{
	// Variables
	[SerializeField] private float _maxHealth;
	[SerializeField] private float _health;
	[SerializeField] private float _strength;
	[SerializeField] private float _dexterity;
	[SerializeField] private float _intelligence;
	[SerializeField] private float _luck;

	// Properties
	public float MaxHealth => _maxHealth;
	public float Health => _health;
	public float Strength => _strength;
	public float Dexterity => _dexterity;
	public float Intelligence => _intelligence;
	public float Luck => _luck;
}
