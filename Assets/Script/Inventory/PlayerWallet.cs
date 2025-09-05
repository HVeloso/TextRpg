public class PlayerWallet : IWallet
{
	// Variables
	private float _money;

	// Wallet Functions
	public float GetMoneyQuantity() => _money;

	public void IncreaseMoney(float moneyToAdd)
	{
		if (moneyToAdd < 0) return;
		_money += moneyToAdd;
	}

	public bool TryBuy(float moneyToDecrease)
	{
		if (moneyToDecrease < 0f || moneyToDecrease > _money) return false;

		_money -= moneyToDecrease;
		return true;
	}
}
