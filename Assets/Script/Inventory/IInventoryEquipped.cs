public interface IInventoryEquipped
{
	public void RegisterWeapon(int weaponIdx, IWeapon item);
	public void UnregisterWeapon(int weaponIdx);
	public IWeapon GetWeapon(int weaponIdx);

	public void RegisterConsumable(int consumableIdx, IPotion item);
	public void UnregisterConsumable(int consumableIdx);
	public IPotion GetConsumable(int consumableIdx);
}
