public interface IPotion
{
	public int Quantity { get; }

	public bool AddItem();
	public bool RemoveItem();
	public void UsePotion(/* Não lembro qual o script que ia aqui kk, mas era um que tinha os status do jogador*/);
}
