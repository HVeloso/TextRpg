using System;
using System.Collections.Generic;

public class EntityStatus
{
	private readonly EntityBaseStatus _baseStatus;
	private readonly Dictionary<StatType, List<StatModifier>> _statusModifiers;
	private readonly Dictionary<StatType, float> _entityStatus;
	private readonly Dictionary<StatType, Action<float>> _entityStatusChanged;

	public EntityStatus(EntityBaseStatus baseStatus)
	{
		_baseStatus = baseStatus;
		_statusModifiers = new();
		_entityStatus = new();
	}

	public void RecalculateStat(StatType type)
	{
		if (!_entityStatus.ContainsKey(type)) _entityStatus.Add(type, 0f);

		float statValue = _baseStatus.GetStat(type);
		_statusModifiers[type].ForEach(x => statValue += x.value);

		_entityStatus[type] = statValue;

		if (_entityStatusChanged.ContainsKey(type))
			_entityStatusChanged[type]?.Invoke(statValue);
	}

	public void RegisterStatsChangedEvent(StatType type, Action<float> onChanged)
	{
		if (!_entityStatusChanged.ContainsKey(type)) _entityStatusChanged.Add(type, null);

		if (_entityStatusChanged[type] == null) _entityStatusChanged[type] = onChanged;
		else _entityStatusChanged[type] += onChanged;
	}
	
	public void UnregisterStatsChangedEvent(StatType type, Action<float> onChanged)
	{
		if (!_entityStatusChanged.ContainsKey(type)) return;
		
		_entityStatusChanged[type] -= onChanged;
	}
}

public enum StatType
{
	Health,
	Strength,
	Luck,
	Dexterity
}
