using System.Collections.Generic;
using UnityEditor;

public class EntityStatusSheet : IStatusSheet
{
	private Dictionary<StatType, EntityStat> _statusSheet;

	public EntityStatusSheet(Dictionary<StatType, EntityStat> newStatusSheet)
	{
		_statusSheet = new(newStatusSheet);
	}

    public EntityStat GetStat(StatType type) => _statusSheet[type];

    public void UpdateStatValue(StatType type, StatValueType valueType, float newValue)
    {
		//_statusSheet[type]
    }
}
