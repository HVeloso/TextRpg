public class EntityStatusSheet : IStatusSheet
{
	// Variables
	private float _maxHealth;
	private float _health;
	private float _strength;
	private float _dexterity;
	private float _intelligence;
	private float _luck;
	
	// Properties
	public float MaxHealth { get { return _maxHealth; } set { _maxHealth = value; } }
	public float Health { get { return _health; } 
		set {
			if (_health + value > _maxHealth) _health = _maxHealth;
			else _health += value;
		}
	}

	public float Strength { get { return _strength; } set { _strength = value; } }
	public float Dexterity { get { return _dexterity; } set { _dexterity = value; } }
	public float Intelligence { get { return _intelligence; } set { _intelligence = value; } }
	public float Luck { get { return _luck; } set { _luck = value; } }
}
