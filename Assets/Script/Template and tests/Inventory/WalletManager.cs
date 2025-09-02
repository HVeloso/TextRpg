using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WalletManager : MonoBehaviour
{
	[Header("Text Components")]
	[SerializeField] private TextMeshProUGUI _moneyText;
	[SerializeField] private TextMeshProUGUI _warningText;
	
	[Header("Money Interaction Buttons")]
	[SerializeField] private Button _increaseMoneyButton;
	[SerializeField] private Button _decreaseMoneyButton;

	private IWallet _playerWallet;
	private bool _warningIsActive;

	private void Awake() => _playerWallet = ServiceLocator.Get<IWallet>();

	private void Start()
	{
		_increaseMoneyButton.onClick.AddListener(IncreaseMoney);
		_decreaseMoneyButton.onClick.AddListener(DecreaseMoney);
		_warningText.gameObject.SetActive(false);
		_warningIsActive = false;
		UpdateTextUI();
	}

	private void UpdateTextUI() => _moneyText.text = $"$ {_playerWallet.GetMoneyQuantity()}";

	private void IncreaseMoney()
	{
		_playerWallet.IncreaseMoney(12f);
		UpdateTextUI();
	}

	private void DecreaseMoney()
	{
		if (_playerWallet.TryBuy(7f)) UpdateTextUI();
		else
		{
			if (!_warningIsActive) StartCoroutine(WarningMessage());
		}
	}

	private IEnumerator WarningMessage()
	{
		_warningIsActive = true;
		_warningText.gameObject.SetActive(true);

		yield return new WaitForSeconds(1.7f);

		_warningText.gameObject.SetActive(false);
		_warningIsActive = false;
	}
}
