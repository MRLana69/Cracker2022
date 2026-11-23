using System;
using InAppPurchase;
using UnityEngine;

public class BundlePurchaseButton : MonoBehaviour
{
	private GameObject activeButtonContents;

	private GameObject inactiveButtonContents;

	private UILabel titleLabel;

	private UILabel priceLabel;

	private UISprite bundle1Icon;

	private UISprite bundle2Icon;

	private UISprite bundle3Icon;

	private UISprite bundle4Icon;

	private UISprite bundle5Icon;

	private BundleContentSlot coinsSlot;

	private BundleContentSlot hoverboardsSlot;

	private BundleContentSlot keysSlot;

	private BundleContentSlot headstartSlot;

	private BundleContentSlot scoreboosterSlot;

	private InAppData.BundleTier _lastPurchasedBundle;

	private void OnEnable()
	{
		InitializeButton();
		UpdateButton();
	}

	private void OnClick()
	{
		InAppManager instance = InAppManager.instance;
		InAppData.BundleTier bundleToSell = GetBundleToSell();
		string bundleId = InAppData.GetBundleId(bundleToSell);
		instance.StartPurchase(bundleId);
		UpdateButton();
	}

	private unsafe void InitializeButton()
	{
		InAppManager instance = InAppManager.instance;
		InAppManager.OnProductRequestDone onProductRequestDone = default;
		onProductRequestDone._002Ector(this, (nint)__ldftn(BundlePurchaseButton.OnProductRequestDone));
		instance.onProductRequestDone += onProductRequestDone;
		InAppManager instance2 = InAppManager.instance;
		InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
		onPurchaseSuccess._002Ector(this, (nint)__ldftn(BundlePurchaseButton.OnPurchaseSuccess));
		instance2.onPurchaseSuccess += onPurchaseSuccess;
		InAppManager instance3 = InAppManager.instance;
		InAppManager.OnPurchaseFailure onPurchaseFailure = default;
		onPurchaseFailure._002Ector(this, (nint)__ldftn(BundlePurchaseButton.OnPurchaseFailure));
		instance3.onPurchaseFailure += onPurchaseFailure;
	}

	private unsafe void OnDisable()
	{
		InAppManager instance = InAppManager.instance;
		if (instance != null)
		{
			InAppManager.OnProductRequestDone onProductRequestDone = default;
			onProductRequestDone._002Ector(this, (nint)__ldftn(BundlePurchaseButton.OnProductRequestDone));
			instance.onProductRequestDone -= onProductRequestDone;
			InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
			onPurchaseSuccess._002Ector(this, (nint)__ldftn(BundlePurchaseButton.OnPurchaseSuccess));
			instance.onPurchaseSuccess -= onPurchaseSuccess;
			InAppManager.OnPurchaseFailure onPurchaseFailure = default;
			onPurchaseFailure._002Ector(this, (nint)__ldftn(BundlePurchaseButton.OnPurchaseFailure));
			instance.onPurchaseFailure -= onPurchaseFailure;
		}
	}

	private void UpdatePrice()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		_lastPurchasedBundle = instance._lastPurchasedBundle;
		InAppData.BundleTier bundleToSell = GetBundleToSell();
		string bundleId = InAppData.GetBundleId(bundleToSell);
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(bundleId);
		string localizedPrice = inAppItemModel.LocalizedPrice;
		priceLabel.text = localizedPrice;
	}

	private void OnProductRequestDone()
	{
		UpdatePrice();
	}

	private void OnPurchaseSuccess(string productId, bool wasRestored)
	{
		UpdateButton();
	}

	private void OnPurchaseFailure(string data, PurchaseResult ressult)
	{
		UpdateButton();
	}

	private InAppData.BundleTier GetBundleToSell()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		InAppData.BundleTier result;
		if (_lastPurchasedBundle != InAppData.BundleTier.None)
		{
			bool flag = _lastPurchasedBundle == InAppData.BundleTier.BundleTier1;
			result = InAppData.BundleTier.BundleTier2;
			if (!flag)
			{
				if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier2)
				{
					if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier3)
					{
						if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier4)
						{
							if (_lastPurchasedBundle == InAppData.BundleTier.BundleTier5)
							{
								result = InAppData.BundleTier.None;
							}
							else
							{
								_ = -1;
								obj = (Enum)(object)typeof(InAppData.BundleTier);
								_ = _lastPurchasedBundle;
								string text = obj.ToString();
								string text2 = "Unidetified bundle tier: " + text;
								result = InAppData.BundleTier.None;
							}
						}
						else
						{
							result = InAppData.BundleTier.BundleTier5;
						}
					}
					else
					{
						result = InAppData.BundleTier.BundleTier4;
					}
				}
				else
				{
					result = InAppData.BundleTier.BundleTier3;
				}
			}
		}
		else
		{
			result = InAppData.BundleTier.BundleTier1;
		}
		return result;
	}

	private unsafe void UpdateButton()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Ref, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Ref, but got Unknown
		//IL_0112: Expected I4, but got Obj
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Ref, but got Unknown
		//IL_01d9: Expected I4, but got Obj
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Ref, but got Unknown
		//IL_02a0: Expected I4, but got Obj
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Ref, but got Unknown
		//IL_0367: Expected I4, but got Obj
		//IL_042e: Expected I4, but got Obj
		object obj = default;
		BundlePurchaseButton bundlePurchaseButton = (BundlePurchaseButton)(obj - 32);
		bundlePurchaseButton.priceLabel = null;
		bundlePurchaseButton.titleLabel = null;
		bundlePurchaseButton.inactiveButtonContents = null;
		bundlePurchaseButton.activeButtonContents = null;
		PlayerInfo instance = PlayerInfo.Instance;
		_lastPurchasedBundle = instance._lastPurchasedBundle;
		if (instance._lastPurchasedBundle != InAppData.BundleTier.BundleTier5)
		{
			ShowActiveContents(active: true);
			InAppData.BundleTier bundleToSell = GetBundleToSell();
			string bundleId = InAppData.GetBundleId(bundleToSell);
			InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(bundleId);
			titleLabel.text = inAppItemModel.DisplayName__BackingField;
			ShowBundleIcon();
			UpdatePrice();
			bundlePurchaseButton.bundle1Icon = null;
			bool flag = inAppItemModel.BundleContents__BackingField.TryGetValue(InAppItemModel.ItemType.Coins, out *(int*)(bundlePurchaseButton + 28));
			GameObject gameObject = coinsSlot.gameObject;
			if ((nint)bundlePurchaseButton.bundle1Icon >= 1)
			{
				gameObject.SetActive(value: true);
				string formattedAmount = bundlePurchaseButton.GetFormattedAmount((int)bundlePurchaseButton.bundle1Icon);
				coinsSlot.UpdateAmount(formattedAmount);
			}
			else
			{
				gameObject.SetActive(value: false);
			}
			bundlePurchaseButton.priceLabel = null;
			bool flag2 = inAppItemModel.BundleContents__BackingField.TryGetValue(InAppItemModel.ItemType.Hoverboards, out *(int*)(bundlePurchaseButton + 24));
			GameObject gameObject2 = hoverboardsSlot.gameObject;
			if ((nint)bundlePurchaseButton.priceLabel >= 1)
			{
				gameObject2.SetActive(value: true);
				string formattedAmount2 = bundlePurchaseButton.GetFormattedAmount((int)bundlePurchaseButton.priceLabel);
				hoverboardsSlot.UpdateAmount(formattedAmount2);
			}
			else
			{
				gameObject2.SetActive(value: false);
			}
			bundlePurchaseButton.titleLabel = null;
			bool flag3 = inAppItemModel.BundleContents__BackingField.TryGetValue(InAppItemModel.ItemType.Keys, out *(int*)(bundlePurchaseButton + 20));
			GameObject gameObject3 = keysSlot.gameObject;
			if ((nint)bundlePurchaseButton.titleLabel >= 1)
			{
				gameObject3.SetActive(value: true);
				string formattedAmount3 = bundlePurchaseButton.GetFormattedAmount((int)bundlePurchaseButton.titleLabel);
				keysSlot.UpdateAmount(formattedAmount3);
			}
			else
			{
				gameObject3.SetActive(value: false);
			}
			bundlePurchaseButton.inactiveButtonContents = null;
			bool flag4 = inAppItemModel.BundleContents__BackingField.TryGetValue(InAppItemModel.ItemType.Headstarts, out *(int*)(bundlePurchaseButton + 16));
			GameObject gameObject4 = headstartSlot.gameObject;
			if ((nint)bundlePurchaseButton.inactiveButtonContents >= 1)
			{
				gameObject4.SetActive(value: true);
				string formattedAmount4 = bundlePurchaseButton.GetFormattedAmount((int)bundlePurchaseButton.inactiveButtonContents);
				headstartSlot.UpdateAmount(formattedAmount4);
			}
			else
			{
				gameObject4.SetActive(value: false);
			}
			bundlePurchaseButton.activeButtonContents = null;
			bool flag5 = inAppItemModel.BundleContents__BackingField.TryGetValue(InAppItemModel.ItemType.Scoreboosters, out *(int*)(bundlePurchaseButton + 12));
			GameObject gameObject5 = scoreboosterSlot.gameObject;
			if ((nint)bundlePurchaseButton.activeButtonContents >= 1)
			{
				gameObject5.SetActive(value: true);
				string formattedAmount5 = bundlePurchaseButton.GetFormattedAmount((int)bundlePurchaseButton.activeButtonContents);
				scoreboosterSlot.UpdateAmount(formattedAmount5);
			}
			else
			{
				gameObject5.SetActive(value: false);
			}
		}
		else
		{
			ShowActiveContents(active: false);
		}
	}

	private void ShowActiveContents(bool active)
	{
		activeButtonContents.SetActive(active);
		bool active2 = (byte)((active ? 1u : 0u) ^ 1u) != 0;
		inactiveButtonContents.SetActive(active2);
		Collider component = GetComponent<Collider>();
		component.enabled = active;
	}

	private void ShowBundleIcon()
	{
		GameObject gameObject = bundle1Icon.gameObject;
		bool active = _lastPurchasedBundle == InAppData.BundleTier.None;
		gameObject.SetActive(active);
		GameObject gameObject2 = bundle2Icon.gameObject;
		bool active2 = _lastPurchasedBundle == InAppData.BundleTier.BundleTier1;
		gameObject2.SetActive(active2);
		GameObject gameObject3 = bundle3Icon.gameObject;
		bool active3 = _lastPurchasedBundle == InAppData.BundleTier.BundleTier2;
		gameObject3.SetActive(active3);
		GameObject gameObject4 = bundle4Icon.gameObject;
		bool active4 = _lastPurchasedBundle == InAppData.BundleTier.BundleTier3;
		gameObject4.SetActive(active4);
		GameObject gameObject5 = bundle5Icon.gameObject;
		bool active5 = _lastPurchasedBundle == InAppData.BundleTier.BundleTier4;
		gameObject5.SetActive(active5);
	}

	private unsafe string GetFormattedAmount(int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected I4, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (amount >= 10000)
		{
			int num = amount / 1000;
			int num2 = obj + 8;
			string text = ((int*)num2)->ToString();
			return text + "K";
		}
		int num3 = obj + 12;
		return ((int*)num3)->ToString();
	}
}
