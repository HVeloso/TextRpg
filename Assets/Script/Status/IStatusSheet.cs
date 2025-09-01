public interface IStatusSheet
{
    public EntityStat GetStat(StatType type);

    public void UpdateStatValue(StatType type, StatValueType valueType, float newValue);
}
