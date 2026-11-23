using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI;

public class BuyButtonIngame : MonoBehaviour, IBuyButton
{
	public UpgradeHelper updater;

	public Button PayButton;

	private unsafe void Start()
	{
		Button payButton = PayButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(BuyButtonIngame._003CStart_003Eb__2_0));
		payButton.m_OnClick.AddListener(unityAction);
	}

	public void OnPurchaseSuccessful()
	{
		UpgradeHelper upgradeHelper = updater;
		updater.UpgradePurchased(upgradeHelper._type);
		UpgradeHelper upgradeHelper2 = updater;
		if (upgradeHelper2.boostScreen != null)
		{
			UpgradeHelper upgradeHelper3 = updater;
			upgradeHelper3.boostScreen.InitTable();
			UpgradeHelper upgradeHelper4 = updater;
			IEnumerator routine = upgradeHelper4.boostScreen.ScrollOnTop();
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	public void OnPurchaseFailure()
	{
	}

	private void _003CStart_003Eb__2_0()
	{
		PurchaseHandler instance = PurchaseHandler.Instance;
		UpgradeHelper upgradeHelper = updater;
		instance.PurchaseUpgrade(upgradeHelper._type, this);
	}
}
