public interface IWeapon
{
	public float LowestDamage { get; }
	public float HighestDamage { get; }

	public void UpdateWeaponValues(EntityStatusSheet statusSheet);
}
