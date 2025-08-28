public interface IInventoryEquipped
{
	public void RegisterWeapon(int weaponIdx, IItem item);
	public void UnregisterWeapon(int weaponIdx);
	public IItem GetWeapon(int weaponIdx);

	public void RegisterConsumable(int consumableIdx, IItem item);
	public void UnregisterConsumable(int consumableIdx);
	public IItem GetConsumable(int consumableIdx);
}
