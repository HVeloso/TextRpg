using UnityEngine;
using System.Collections.Generic;

public class EntityStat
{
	// Variables
	public readonly Dictionary<StatValueType, float> _statValues = new()
	{
		{StatValueType.Maximum, 0f},
		{StatValueType.Current, 0f},
		{StatValueType.Minimum, 0f},
	};

	// Initialization
	public EntityStat() { }
	public EntityStat(Dictionary<StatValueType, float> statValue) => _statValues = new(statValue);

	// Stat Value Management
	public float GetValue(StatValueType valueType)
	{
		if (!_statValues.ContainsKey(valueType))
		{
			Debug.LogError($"Stat value do not contains '{valueType}' key.");
			return -1f;
		}

		return _statValues[valueType];
	}

	public void UpdateValue(StatValueType valueType, float newValue)
	{
		switch (valueType)
		{
			case StatValueType.Minimum: SetMinValue(newValue);
				break;

			case StatValueType.Maximum: SetMaxValue(newValue);
				break;

			case StatValueType.Current: SetCurretValue(newValue);
				break;

			default: Debug.LogError($"Stat value do not contains '{valueType}' key.");
				break;
		}
	}
	
	private void SetMaxValue(float value)
	{
		_statValues[StatValueType.Maximum] = value;

		if (_statValues[StatValueType.Maximum] < _statValues[StatValueType.Current])
			_statValues[StatValueType.Current] = value;

		if (_statValues[StatValueType.Maximum] < _statValues[StatValueType.Minimum])
			_statValues[StatValueType.Minimum] = value;
	}

	private void SetMinValue(float value)
	{
		if (value <= 0f)
		{
			Debug.LogError($"Stat value can not be lower than zero.");
			value = 0f;
		}

		_statValues[StatValueType.Minimum] = value;

		if (_statValues[StatValueType.Minimum] > _statValues[StatValueType.Current])
			_statValues[StatValueType.Current] = value;

		if (_statValues[StatValueType.Minimum] > _statValues[StatValueType.Maximum])
			_statValues[StatValueType.Maximum] = value;
	}

	private void SetCurretValue(float value)
	{
		_statValues[StatValueType.Current] = 
			Mathf.Clamp(value, _statValues[StatValueType.Minimum], _statValues[StatValueType.Minimum]);
	}
}
