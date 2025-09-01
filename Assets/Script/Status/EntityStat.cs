public class EntityStat
{
    // Variables
    public  float _maxValue;
    private float _minValue;
    private float _currentValue;

    // Properties
    public float MaxValue
    {
        get { return _maxValue; }
        set {
            _maxValue = value;
            if (_maxValue < _currentValue) 
                _currentValue = _maxValue;
        }
    }

    public float MinValue
    {
        get { return _minValue; }
        set
        {
            _minValue = value;
            if (_minValue > _currentValue)
                _currentValue = _minValue;
        }
    }

    public float CurrentValue { get { return _currentValue; } set { _currentValue = value; } }

    // Initialization
    public EntityStat(float _minValue = 0f, float _maxValue = 0f, float _starterValue = 0f)
    {
        this._minValue = _minValue;
        this._maxValue = _maxValue;
        _currentValue = _starterValue;
    }
}
