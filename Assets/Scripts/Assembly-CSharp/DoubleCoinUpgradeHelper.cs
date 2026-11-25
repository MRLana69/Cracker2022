using System;
using UnityEngine;

public class DoubleCoinUpgradeHelper : DiscountButton
{
	private string doubleCoinVersion;

	private bool inited;

	public bool OnSale
	{
		get
		{
			if (DiscountButton.DiscountDoubleCoins)
			{
				priceModifier = OnlineSettings.instance.GetValue("double_coin_discount", 0);
				if (priceModifier < 0)
				{
					return true;
				}
			}
			return false;
		}
	}

	public override void Awake()
	{
		base.Awake();
		inited = false;
		NGUITools.SetActive(base.gameObject, false);
	}

	private void ForceEndDiscount()
	{
		Debug.Log("Force End Discount", this);
		InAppManager instance = InAppManager.Instance;
		instance.onProductRequestSuccess = (Action)Delegate.Remove(instance.onProductRequestSuccess, new Action(UpdatePrice));
		_Setup(true);
	}

	private unsafe void _Setup(bool forceEndDiscount = false)
	{
		inited = false;
		NGUITools.SetActive(base.gameObject, false);
	}
	private void _SetupNoArgs() { _Setup(); }

	public void Init()
	{
		inited = false;
		NGUITools.SetActive(base.gameObject, false);
	}

	private void OnEnable()
	{
		if (inited)
		{
			_Setup();
		}
	}

	private void UpdatePrice()
	{
		price.text = InAppData.inAppData[doubleCoinVersion].price;
	}

	private void OnClick()
	{
	}
}
