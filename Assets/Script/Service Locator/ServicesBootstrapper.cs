using UnityEngine;

[DefaultExecutionOrder(-1)]
public class ServicesBootstrapper : MonoBehaviour
{
	private void Awake()
	{
		PlayerInventory inventory = new();

		ServiceLocator.Register(inventory as IInventory);
		ServiceLocator.Register(inventory as IInventoryEquipped);
		ServiceLocator.Register(inventory as IWallet);
	}
}
