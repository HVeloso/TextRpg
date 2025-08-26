using UnityEngine;

[CreateAssetMenu(fileName = "EntityBaseStatus", menuName = "Entity Status/EntityBaseStatus")]
public class EntityBaseStatus : ScriptableObject
{
	[Header("Base Status")]
	[SerializeField][Min(0)] private float _health;
	[SerializeField][Min(0)] private float _strength;
	[SerializeField][Min(0)] private float _luck;
	[SerializeField][Min(0)] private float _dexterity;

	// Status Properties
	public float GetStat(StatType type)
	{
		return type switch
		{
			StatType.Health => _health,
			StatType.Strength => _strength,
			StatType.Luck => _luck,
			StatType.Dexterity => _dexterity,
			_ => -1f,
		};
	}
}
