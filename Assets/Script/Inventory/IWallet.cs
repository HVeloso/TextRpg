public interface IWallet
{
	public float GetMoneyQuantity();
	public void IncreaseMoney(float moneyToAdd);
	public bool TryBuy(float moneyToDecrease);
}
