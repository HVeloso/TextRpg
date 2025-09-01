using System.Collections.Generic;
using UnityEngine;

public class EntityStatusSheet : IStatusSheet
{
	// Variables
	private readonly Dictionary<StatType, EntityStat> _statusSheet;

	// Initialization
	public EntityStatusSheet(Dictionary<StatType, EntityStat> baseStatusSheet) => _statusSheet = new(baseStatusSheet);

	// Stat Functions
	public EntityStat GetStat(StatType type) => _statusSheet[type];

	public void UpdateStatValue(StatType type, StatValueType valueType, float newValue)
	{
		if (!_statusSheet.ContainsKey(type))
		{
			Debug.LogError($"Status sheet do not contains '{type}' key.");
			return;
		}

		_statusSheet[type].UpdateValue(valueType, newValue);
	}
}
