using UnityEngine;

[DefaultExecutionOrder(-1)]
public class ServicesBootstrapper : MonoBehaviour
{
	private void Awake()
	{
		ServiceLocator.Register(new PlayerInventory());
	}
}
